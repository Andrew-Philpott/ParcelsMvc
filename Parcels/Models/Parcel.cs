using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Parcels.Models
{

  public class Parcel
  {
    // [Range(1,100, ErrorMessage = "Number must be greater than 1")]
    public int Width { get; }

    // [Range(1,100, ErrorMessage = "Number must be greater than 1")]
    public int Length { get; }

    // [Range(1,100, ErrorMessage = "Number must be greater than 1")]
    public int Depth { get; }
    
    // [Range(1,100, ErrorMessage = "Number must be greater than 1")]
    public double Weight { get; }

    public Parcel(int width, int length, int depth, double weight)
    {
      Width = width;
      Length = length;
      Depth = depth;
      Weight = weight;
    }

    public int Volume()
    {
      return (Width * Length * Depth);
    }

    public double CostToShip()
    {
      int volume = Volume();
      int pricePerPound = 0;
      double baseRate = 5.99;
      double additionalCosts = 0;
      if (volume > 20 && volume <= 50)
      {
        pricePerPound = 1;
        additionalCosts = (pricePerPound * Weight);
      }
      else if (volume <= 100)
      {
        baseRate = 20.00;
        pricePerPound = 3;
        additionalCosts = (pricePerPound * Weight);
      }
      return baseRate + additionalCosts;
    }
  }
}