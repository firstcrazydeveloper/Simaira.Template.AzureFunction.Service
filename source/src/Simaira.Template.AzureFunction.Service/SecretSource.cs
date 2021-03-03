namespace Simaira.Template.AzureFunction.Service
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;

    [TypeConverter(typeof(SecretSourceConverter))]
    public sealed class SecretSource
    {
        public static readonly SecretSource Direct = new SecretSource("Direct", false, false);
        public static readonly SecretSource KeyVault = new SecretSource("KeyVault", true, false);
        public static readonly SecretSource ManagedKeyVault = new SecretSource("ManagedKeyVault", true, true);

        private SecretSource(string source, bool isKeyVault, bool isManaged)
        {
            IsKeyVault = isKeyVault;
            IsManaged = isManaged;
            Source = source;
        }

        public string Source { get; }

        public bool IsKeyVault { get; }

        public bool IsManaged { get; }

        public override string ToString()
        {
            return Source;
        }

        internal sealed class SecretSourceConverter : TypeConverter
        {
            private static readonly Dictionary<string, SecretSource> Fields = typeof(SecretSource)
                .GetFields(BindingFlags.Static | BindingFlags.Public)
                .ToDictionary(ks => ks.Name, es => (SecretSource)es.GetValue(null));

            public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
                if (sourceType == typeof(string))
                {
                    return true;
                }

                return base.CanConvertFrom(context, sourceType);
            }

            public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
            {
                return Fields[value.ToString()];
            }
        }
    }
}
