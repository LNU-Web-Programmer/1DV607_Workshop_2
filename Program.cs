﻿using System;

namespace workshop_2
{
    class Program
    {
        static void Main(string[] args)
        {
           MemberRegister register = new MemberRegister();
            register.addMember("Musse", "Pigg", "9510101349");
            Member member1 = register.getMemberBySsn("9510101349");

            member1.BoatRegister.addBoat(BoatTypes.Sailboat, 4.5);

                foreach (object boat in member1.BoatRegister.Boats)
                {
                     Console.WriteLine(boat.ToString());
                }
            
            
            // register.deleteMemberBySsn("9510101349");
            // Console.WriteLine(register.getMemberBySsn("9510101349").MemberId);

            // Boat two = new Boat(BoatTypes.Sailboat, 1.0);
            // Console.WriteLine(two.Type);

        }
    }
}