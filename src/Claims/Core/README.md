---

title: DGMJR Identity Common
project: Dgmjr.Identity
description: This library contains the base interface and class for claim types and claim value types.
lastmod: 2023-08-29T17:25:51.228Z
date: 2023-08-29T17:25:51.228Z
authors:

- dgmjr
  project: identity

---

# Dgmjr.Identity.Core

This library contains the base interface and class for claim types and claim value types.

## Installation

Install the NuGet package:

```PowerShell
Install-Package Dgmjr.Identity.Common
```

## Usage

To use the library, add the following using statements to your code:

```C#
using Dgmjr.Identity;
using System.Security.Claims.ClaimTypes;
using System.Security.Claims.ClaimValueTypes;
```

Then, you can use the `IIdentityComponent` interface to represent claim types and claim value types. The `IdentityComponent` abstract class provides a base implementation of the `IIdentityComponent` interface.

The following code snippet shows how to create a claim type:

```C#
var claimType = new ClaimType("MyClaimType");
```

The following code snippet shows how to create a claim value type:

```C#
var claimValueType = new ClaimValueType("MyClaimValueType");
```

## Contributing

Contributions are welcome! Please see the [CONTRIBUTING.md](https://github.com/dgmjr-io/.github/blob/main/docs/CONTRIBUTING.md) file for more information.

## License

The Dgmjr.Identity.Core library is licensed under the MIT license. See the [LICENSE](../../LICENSE.md) file for more information.
