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
      int sizeMultiplier = 0;
      if (volume < 20)
      {
        sizeMultiplier = 2;
      }
      else if (volume >= 20 && volume <= 50)
      {
        sizeMultiplier = 3;
      }
      else if (volume <= 100)
      {
        sizeMultiplier = 4;
      }
      else
      {
        sizeMultiplier = 7;
      }
      return sizeMultiplier * volume;
    }
  }
}