namespace Dgmjr.Identity.ClaimValueTypes.Enums;

[GenerateEnumerationRecordStruct("authnmethodsreferences", "Dgmjr.Identity.ClaimValueTypes")]
public enum authnmethodsreferences
{
    [Display(
        Name = "face",
        Description = "Biometric authentication [RFC4949] using facial recognition."
    )]
    face,

    [Display(Name = "fpt", Description = "Biometric authentication [RFC4949] using fingerprint.")]
    fpt,

    [Display(
        Name = "hbk",
        Description = " Use of geolocation information for authentication, such as that provided by [W3C.REC-geolocation-API-20161108]."
    )]
    [Uri("https://www.w3.org/TR/2016/REC-geolocation-API-20161108/")]
    geo,

    [Display(
        Name = "hbk",
        Description = "Proof-of-Possession (PoP) of a hardware-secured key.  See Appendix C of [RFC4211] for a discussion on PoP."
    )]
    hwk,

    [Display(
        Name = "hbk",
        Description = "Multiple-factor authentication [NIST.800-63-2] [ISO29115].  When this is present, specific authentication methods used may also be included."
    )]
    mfa,

    [Display(Name = "iris", Description = "Biometric authentication [RFC4949] using an iris scan.")]
    iris,

    [Display(Name = "kba", Description = "Knowledge-based authentication [NIST.800-63-2].")]
    kba,

    [Display(
        Name = "mca",
        Description = "Multiple-channel authentication [MCA].  The authentication involves communication over more than one distinct communication channel.  For instance, a multiple-channel authentication might involve both entering information into a workstation's browser and providing information on a telephone call to a pre-registered number."
    )]
    mca,

    [Display(Name = "otp", Description = "One-time password [RFC4949].")]
    otp,

    [Display(Name = "pwd", Description = "Password authentication [RFC4949].")]
    pwd,

    [Display(
        Name = "pin",
        Description = "Personal Identification Number (PIN) authentication [RFC4949]."
    )]
    pin,

    [Display(Name = "rba", Description = "Risk-based authentication [ISO29115].")]
    rba,

    [Display(
        Name = "retina",
        Description = "Biometric authentication [RFC4949] using a retina scan."
    )]
    retina,

    [Display(Name = "sc", Description = "Smart card authentication [RFC4949].")]
    sc,

    [Display(Name = "sms", Description = "Short Message Service (SMS) [RFC4949].")]
    sms,

    [Display(Name = "swk", Description = "Software-secured key authentication [RFC4949].")]
    swk,

    [Display(Name = "tel", Description = "Telephone call [RFC4949].")]
    tel,

    [Display(Name = "user", Description = "User presence test [FIDO-UAF-AppIDAndFacets].")]
    user,

    [Display(Name = "wia", Description = "Windows Integrated Authentication [MSDN-WIA].")]
    wia,

    [Display(
        Name = "wsc",
        Description = "Web Services Security Username Token Profile [OASIS-WS-Security]."
    )]
    wsc,

    [Display(Name = "vbm", Description = "Voice biometric authentication [RFC4949].")]
    vbm
}
