using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    public enum TrafficLightSignal
    {
        Red,
        Green,
        Yellow
    }
    public class TrafficLight
    {
        private TrafficLightSignal currentSignal;

        public TrafficLight(string signal)
        {
            this.currentSignal = (TrafficLightSignal)Enum.Parse(typeof(TrafficLightSignal), signal);
        }

        public void Update()
        {
            int previous = (int)currentSignal;
       
            currentSignal = (TrafficLightSignal)(++previous % Enum.GetNames(typeof(TrafficLightSignal)).Length);
 
        }
    }
    internal class Program
    {



        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split();
            TrafficLight[] trafficLights = new TrafficLight[data.Length];
            for (int i = 0; i < trafficLights.Length; i++)
            {
                trafficLights[i] = (TrafficLight)Activator.CreateInstance(typeof(TrafficLight), new object[] { data[i] });
       

            }
   
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> output = new List<string>();
                foreach (var trafficLight in trafficLights)
                {
                    trafficLight.Update();
                  
                    output.Add(typeof(TrafficLight)
                        .GetField("currentSignal", BindingFlags.NonPublic | BindingFlags.Instance)
                        .GetValue(trafficLight).ToString());
                }
                for (int j = 0; j < output.Count; j++)
                {
                    Console.Write(output[j]+" ");


                }
                Console.WriteLine( " ");
            }
        }
    }
}
