[![](https://img.shields.io/nuget/v/soenneker.stripe.enums.collectionmethods.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.collectionmethods/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.collectionmethods/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.collectionmethods/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.stripe.enums.collectionmethods.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.collectionmethods/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.collectionmethods/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.collectionmethods/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Stripe.Enums.CollectionMethods

Provides strongly typed values for Stripe subscription and invoice collection methods: automatic charging and invoice delivery.

## Installation

```bash
dotnet add package Soenneker.Stripe.Enums.CollectionMethods
```

## Usage

```csharp
using Soenneker.Stripe.Enums.CollectionMethods;

StripeCollectionMethod method = StripeCollectionMethod.ChargeAutomatically;
string stripeValue = method.Value; // "charge_automatically"

StripeCollectionMethod parsed =
    StripeCollectionMethod.FromValue("send_invoice");
```

The type supports value lookup, name lookup, enumeration through `List`, JSON conversion, and implicit conversion to `string`.
