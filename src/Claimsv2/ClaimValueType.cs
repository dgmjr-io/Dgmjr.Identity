using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
namespace Dgmjr.Identity.Claims;

public class ClaimValueTypeBase<TBaseType> : ClaimValueTypeBase, IValidator<TBaseType>
{
    public virtual ValidationResult Validate(TBaseType instance)
    {
        return new ValidationResult("Not implemented");
    }
    public virtual Task<ValidationResult> ValidateAsync(TBaseType instance, CancellationToken cancellationToken)
    {
        return Task.Run(() => Validate(instance, context));
    }
}

public class ClaimValueTypeBase
{
    public string UriString { get; }
    public uri Uri => new uri(UriString);
    public string Name { get; }
    public string Description { get; }
    public uri Namespace => new uri(NamespaceString);
    protected string NamespaceString { get; }
    public string NamespacePrefix { get; }
}

public class XS : ClaimValueTypeBase
{
    public class TypedXS<T> : ClaimValueTypeBase<string>
    {
        public TypedXS() : base(TypedXS<T>.Name, TypedXS<T>.Description, XS.NamespacePrefix, XS.NamespaceString) { }

        /// <summary>
        /// The name of the claim value type
        /// </summary>
        /// <value>xs</value>
        public new const string Name = nameof(T);

        /// <summary>
        /// The description of the claim value type
        /// </summary>
        /// <value>XML Schema</value>
        public new const string Description = XS.Description;

        /// <summary>
        /// The namespace prefix of the claim value type
        /// </summary>
        /// <value>xs</value>
        public new const string NamespacePrefix = XS.NamespacePrefix;
        /// <summary>
        /// The namespace of the claim value type
        /// </summary>
        /// <value>http://www.w3.org/2001/XMLSchema#</value>
        public new const string NamespaceString = XS.NamespaceString;
    }

    public XS(string name, string description, string namespacePrefix, string namespaceString)
    {
        Name = name;
        Description = description;
        NamespacePrefix = namespacePrefix;
        NamespaceString = namespaceString;
    }

    /// <summary>
    /// The name of the claim value type
    /// </summary>
    /// <value>xs</value>
    public const string Name = nameof(XS);
    /// <summary>
    /// The description of the claim value type
    /// </summary>
    /// <value>XML Schema</value>
    public const string Description = "XML Schema";
    /// <summary>
    /// The namespace prefix of the claim value type
    /// </summary>
    /// <value>xs</value>
    public const string NamespacePrefix = nameof(XS);
    /// <summary>
    /// The namespace of the claim value type
    /// </summary>
    /// <value>http://www.w3.org/2001/XMLSchema#</value>
    public const string NamespaceString = "http://www.w3.org/2001/XMLSchema#";
    public class AnyURI : TypedXS<uri>
    {
        public AnyURI() : base(Name, Description, NamespacePrefix, XS.NamespaceString) { }

        public const string Name = "anyURI";
        public const string Description = "A URI";
    }

    public class Base64Binary : TypedXS<string>
    {
        public Base64Binary() : base(Name, Description, NamespacePrefix, XS.NamespaceString) { }

        public const string Name = "base64Binary";
        public const string Description = "A base64 encoded binary value";
    }

    public class Integer32 : TypedXS<int>
    {
        public Integer32() : base(Name, Description, NamespacePrefix, NamespaceString) { }
        public const string Name = "integer32";
        public const string Description = "A 32 bit integer";
    }
    public class UInteger32 : TypedXS<uint>
    {
        public UInteger32() : base(Name, Description, NamespacePrefix, NamespaceString) { }
        public const string Name = "uinteger32";
        public const string Description = "A 32 bit unsigned integer";
    }
}
