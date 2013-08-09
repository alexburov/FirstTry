﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingOO
{
  internal class Automobile
  {
    private string make;

    public string Model;

    public int Year;

    public string Color;

    public int Miles;

    private int speed;

    public Engine Engine;




    public AutoCustomer Customer = new AutoCustomer();

    public class AutoCustomer
    {
      public string LastName;

      public string Address;

      public DateTime DateOfPurchase;
    }

    public string Maker
    {
      get
      {
        return make;
      }
      set
      {
        make = value;
      }
    }

    public int CurrentSpeed
    {
      get
      {
        return speed;
      }
      set
      {
        if (value < 0) speed = 0;
        else if (value > 110) speed = 110;
        else speed = value;
      }
    }




    public int Accelerate(int increasedSpeed)
    {
      CurrentSpeed += increasedSpeed;
      writeLine("Current speed: " + CurrentSpeed);
      //Console.WriteLine("Current speed: " + Speed.ToString());

      return CurrentSpeed;
    }

    public int Decelerate(int decreasedSpeed)
    {
      CurrentSpeed -= decreasedSpeed;
      //Console.WriteLine("Current speed: " + Speed.ToString());
      writeLine("Current speed: " + CurrentSpeed);
      return CurrentSpeed;
    }

    public string SpeedLimitViolation(string initialMessage, int speedLimit)
    {
      string message = "";

      if (CurrentSpeed > speedLimit) message = "Too fast";
      else message = "You're OK";

      return initialMessage + " " + message;
    }

    private void writeLine(string message)
    {
      if (message != null)
      {
        Console.Write("FROM MY HELPER METHOD ... ");
        Console.WriteLine(message);
      }
    }

  }
}
