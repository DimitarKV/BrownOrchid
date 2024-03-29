﻿using System.ComponentModel.DataAnnotations;
using BrownOrchid.Common.Domain.Entities;

namespace BrownOrchid.Services.App.Data.Entities;

public class Discount
{
    [Key]
    public string DiscountId { get; set; }
    public Dealer Dealer { get; set; }
    public int Amount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DiscountStatusEnum DiscountStatus { get; set; }

    public Discount()
    {
        DiscountId = Guid.NewGuid().ToString();
    }

    public enum DiscountStatusEnum
    {
        ACTIVE,
        EXPIRED,
        REJECTED,
        WAITING
    }
}