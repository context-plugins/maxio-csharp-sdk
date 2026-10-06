using Maxio.Models;

namespace Maxio.Requests.Coupons;

/// <summary>
/// The inputs of the CreateCoupon operation.
/// </summary>
public sealed record CreateCouponRequest
{
    /// <summary>
    /// The Advanced Billing id of the product family to which the coupon belongs
    /// </summary>
    public required int ProductFamilyId { get; init; }

    public CouponRequest? Body { get; init; }
}
