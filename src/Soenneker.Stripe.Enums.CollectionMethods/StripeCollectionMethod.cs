using Soenneker.Gen.EnumValues;

namespace Soenneker.Stripe.Enums.CollectionMethods;

/// <summary>
/// Stripe collection methods enum
/// </summary>
[EnumValue<string>]
public sealed partial class StripeCollectionMethod
{
    /// <summary>
    /// Charge automatically
    /// </summary>
    public static readonly StripeCollectionMethod ChargeAutomatically = new("charge_automatically");

    /// <summary>
    /// Send invoice
    /// </summary>
    public static readonly StripeCollectionMethod SendInvoice = new("send_invoice");
}