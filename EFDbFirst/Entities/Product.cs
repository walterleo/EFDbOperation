﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFDbFirst.Entities;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; }

    public string Price { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; }
}