using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UncheckedInformationSite.Models
{
    public class AdventureVM
    {

        public Int32 RoomNumber { get; set; }
        public String PreviousText { get; set; }
        public String CurrentText { get; set; }
        public String UserResponse { get; set; }
        public String HeldItem { get; set; }

        public void RunGame()
        {
            PreviousText = CurrentText;
            if (HeldItem == null)
            {
                HeldItem = "Nothing";
            }
            /*else
            {
                if (HeldItem == "Shovel")
                {
                    HeldItem = "no";
                }
            }*/

            if (RoomNumber < 4 && RoomNumber > 0)
            {
                //non room specific tasks
                if (UserResponse == "cookie" && HeldItem == "cookie")
                {
                    CurrentText = "You throw the cookie with all the might of your bones.";
                    HeldItem = "Nothing";
                }
                else if (UserResponse == "eat")
                {
                    CurrentText = "There is nothing to eat.";
                }
                else if (UserResponse == "eat cookie" && HeldItem == "cookie")
                {
                    CurrentText = "It tasted great!";
                }

                //room specific tasks
                else if (RoomNumber == 1) //graveyard
                {
                    if (UserResponse == "look")
                    {
                        CurrentText = "You stand in the cemetery. A blue 1970s DESOTO rests upon the gravel parking lot. The left most grave looks loose, but not loose enough for you bare hands. To your right is the country road (Room 2) with your car parked in a ditch and to the left is an old shack (Room 3).";
                    }
                    else if (UserResponse == "shovel" && HeldItem == "shovel")
                    {
                        CurrentText = "You dig up the grave and find a car key.";
                        HeldItem = "key";
                    }
                    else if (UserResponse == "desoto" && HeldItem == "spear")
                    {
                        CurrentText = "You stab the DESOTO repeatedly, until it bleeds. You laugh out in victory, along with JACK.";
                    }
                    else if (UserResponse == "desoto")
                    {
                        CurrentText = "Its locked. Too bad too, youve always wanted a Desoto.";
                    }
                    else if (UserResponse == "key" && HeldItem == "key")
                    {
                        CurrentText = "You jump in the Desoto and drive off. It runs out of gas pretty quickly, so you leave the car and walk home empty handed. You Win!";
                    }
                    else if (UserResponse == "flashlight" && HeldItem == "flashlight")
                    {
                        CurrentText = "You use the flashlight for morse code, flickering it upon the night sky. The fool MOON flickers you a message back. Their on to you.";
                    }
                    else if (UserResponse == "jack" && HeldItem == "spear")
                    {
                        CurrentText = "You stab Jack. You cry. You burry him.";
                    }
                    else if (UserResponse == "jack" && HeldItem == "shovel")
                    {
                        CurrentText = "You burry Jack.";
                    }
                    else if (UserResponse == "jack")
                    {
                        CurrentText = "You talk to Jack.";
                    }
                    else if (UserResponse == "moon" && HeldItem == "spear")
                    {
                        CurrentText = "You stab the moon, it fall like a sack of Polish dancers... But then two more fly up and takes its place.";
                    }
                    else if (UserResponse == "moon")
                    {
                        CurrentText = "You look at the moon, always keeping an eye on it.";
                    }
                }
                else if (RoomNumber == 2) //country road
                {
                    if (UserResponse == "look")
                    {
                        CurrentText = "Your police VEHICLE sits precariously on the side of the road. On the groud is a pair of unrecognizable KEYS and a sugar COOKIE. Inside your car is your trusty FLASHLIGHT.";
                    }
                    else if (UserResponse == "vehicle")
                    {
                        CurrentText = "You push your car into the ditch. You now have no way home, so I guess your working overtime.";
                    }
                    else if (UserResponse == "cookie" && HeldItem != "shovel")
                    {
                        CurrentText = "You take the cookie and hold onto it tightly.";
                        HeldItem = "cookie";
                    }
                    else if (UserResponse == "keys")
                    {
                        CurrentText = "You pick up the keys off the ground.";
                        if (HeldItem == "flashlight" || HeldItem == "keys and flashlight")
                        {
                            HeldItem = "keys and flashlight";
                        }
                        else if (HeldItem != "shovel")
                        {
                            HeldItem = "keys";
                        }
                    }
                    else if (UserResponse == "flashlight")
                    {
                        CurrentText = "You pick up your amazing flashlight.";
                        if (HeldItem == "keys" || HeldItem == "keys and flashlight")
                        {
                            HeldItem = "keys and flashlight";
                        }
                        else if (HeldItem != "shovel")
                        {
                            HeldItem = "flashlight";
                        }
                    }
                    else if (UserResponse == "shovel" && HeldItem == "shovel")
                    {
                        CurrentText = "You dig up the road making it uncrossable. You monster.";
                    }
                }
                else if (RoomNumber == 3) //shack
                {
                    if (UserResponse == "look")
                    {
                        if (HeldItem != "keys" && HeldItem != "keys and flashlight")
                        {
                            CurrentText = "The door to the shack is locked.";
                        }
                        else if (HeldItem != "flashlight" && HeldItem != "keys and flashlight")
                        {
                            CurrentText = "Its too dark to see in here, you need a candle or something.";
                        }
                        else
                        {
                            CurrentText = "You look around the shack. The only thing in it are SHOVELs. A lot of SHOVELs. Besides that its spotless, except for all the dead animals. Oh and there is also a MINIFRIDGE. And a DUCK. There are some BALLOONs handing from the ceiling. Along with a ceiling fan and a SKULL. Not a lot in this room. Well there is the SPEAR.";
                        }
                    }
                    else if (UserResponse == "balloon" && HeldItem == "spear")
                    {
                        CurrentText = "You pop the birthday balloons. RIP little Timmies birthday, he was going to turn 5 the same day they had the funeral planned.";
                    }
                    else if (UserResponse == "duck" && HeldItem == "spear")
                    {
                        CurrentText = "You kill the duck and put it in the MINIFRIDGE.";
                    }
                    else if (UserResponse == "skull" && HeldItem == "spear")
                    {
                        CurrentText = "You get a Crit and the skull dies in one Hit! You get 2343 exp and level up to level 4 unlocking firebolt and dehydration beam.";
                    }
                    else if (UserResponse == "skull" || UserResponse == "balloon")
                    {
                        CurrentText = "You cant reach it.";
                    }
                    else if (UserResponse == "duck")
                    {
                        CurrentText = "It waddles off pretty quickly, all the while staring you in the eyes.";
                    }
                    else if (UserResponse == "MINIFRIDGE")
                    {
                        CurrentText = "You grab and drink a nice refreshing IV bag full of type F blood.";
                    }
                    else if (UserResponse == "shovel")
                    {
                        CurrentText = "You take one of the infinite amout of shovels";
                        HeldItem = "shovel";
                    }
                    else if (UserResponse == "spear")
                    {
                        CurrentText = "You grab a spear. Well not A spear, THE spear, there is only one.";
                        HeldItem = "spear";
                    }
                    else if (UserResponse == "yui")
                    {
                        CurrentText = "You";
                    }
                }
                else
                {
                    CurrentText = "Command not Accepted.";
                }
            }
            else
            {
                CurrentText = "You wonder off into the depths of space only to find that no such room exsists. What a disappointment.";
            }
        }
    }
}
