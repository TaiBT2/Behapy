﻿namespace Behapy.Presentation.Models;

public class ProductPromotion
{
    public int Id { get; init; }

    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public int PromotionId { get; set; }
    public Promotion Promotion { get; set; } = null!;
}