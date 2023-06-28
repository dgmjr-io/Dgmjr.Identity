namespace Dgmjr.Identity.Claims.Abstractions;

public interface IClaimTypeOrValue
{
    /// <summary>
    /// The separator used to separate the prefix from the name of the claim type or value.
    /// </summary>
    string LongUriSeparator { get; }
    /// <summary>
    /// The separator used to separate the prefix from the name of the claim type or value.
    /// </summary>
    string ShortUriSeparator { get; }
    /// <summary>
    /// The description of the claim type or value.
    /// </summary>
    string Description { get; }
    /// <summary>
    /// The prefix of the claim type or value (in its long form).
    /// </summary>
    string LongUriPrefix { get; }
    /// <summary>
    /// The prefix of the claim type or value (in its short form).
    /// </summary>
    string ShortUriPrefix { get; }
    /// <summary>
    /// The URI of the claim type or value (in its long form).
    /// </summary>
    string ShortUriString { get; }
    /// <summary>
    /// The URI of the claim type or value (in its short form).
    /// </summary>
    string LongUriString { get; }
    /// <summary>
    /// The name of the claim type or value.
    /// </summary>
    string Name { get; }
    uri Uri { get; }
    /// <summary>
    /// The URI of the claim type or value (in its short form).
    /// </summary>
    uri ShortUri { get; }
    /// <summary>
    /// The URI of the claim type or value (in its long form).
    /// </summary>
    uri LongUri { get; }
}
