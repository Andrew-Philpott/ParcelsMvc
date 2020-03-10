using System;
using System.Collections.Generic;

namespace Parcels.Models
{

  public class Parcel
  {
    public int Width { get; }

    public int Length { get; }

    public int Depth { get; }
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