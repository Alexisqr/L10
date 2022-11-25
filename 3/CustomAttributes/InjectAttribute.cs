namespace _03BarracksFactory.CustomAttributes
{
    using System;

    [AttributeUsage(AttributeTargets.Field)] //За допомогою атрибута AttributeUsage можна обмежити
                                             //типи, до яких застосовуватиметься атрибут.
                                             //Field: застосовується до поля типу
    public class InjectAttribute : Attribute
    {
    }
}