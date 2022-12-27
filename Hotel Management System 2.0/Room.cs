using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_2._0
{
    public class Room:BaseInformation
    {
        public List<Room> roomList = new List<Room>();
        
        public void AddTypeRoom()
        {
            Room room1 = new Room();
            room1.Type = "Standard";
            roomList.Add(room1);

            Room room2 = new Room();
            room2.Type = "Standard";
            roomList.Add(room2);

            Room room3 = new Room();
            room3.Type = "Standard";
            roomList.Add(room3);

            Room room4 = new Room();
            room4.Type = "Vip";
            roomList.Add(room4);

            Room room5 = new Room();
            room5.Type = "Vip";
            roomList.Add(room5);

            Room room6 = new Room();
            room6.Type = "Vip";
            roomList.Add(room6);

            Room room7 = new Room();
            room7.Type = "Family";
            roomList.Add(room7);

            Room room8 = new Room();
            room8.Type = "Family";
            roomList.Add(room8);

            Room room9 = new Room();
            room9.Type = "Family";
            roomList.Add(room9);
        }
        public bool CheckStatus(int i)
        {
            bool tmp = false;

            if (roomList[i].Name == null)
            {
                tmp = true;
            }
            return tmp;
        }
        public void CheckRoom(string request)
        {
            Console.WriteLine("<<Rooms that match customer requirements are still available>>");
            for (int i = 0; i < roomList.Count; i++)
            {
                if (string.Compare(request, roomList[i].Type) == 0)
                {
                    bool check = CheckStatus(i);
                    if (check == true)
                    {
                        Console.WriteLine($"{roomList[i].Type} Room {i + 1} is available");
                    }
                }
            }
        }
        public List<int> RoomAvailable(string request)
        {
            List<int> roomAvailable = new List<int>();
            for (int i = 0; i < roomList.Count; i++)
            {
                if (string.Compare(request, roomList[i].Type) == 0)
                {
                    bool check = CheckStatus(i);
                    if (check == true)
                    {
                        roomAvailable.Add(i + 1);
                    }
                }
            }
            return roomAvailable;
        }

        public void ConfirmRent(string name, int time, string request)
        {
            int roomNumber;
            bool check;
            do
            {
                check = false;
                Console.Write("What is Room You Want to Rent: ");
                roomNumber = int.Parse(Console.ReadLine());
                List<int> RoomCanRent = RoomAvailable(request);
                foreach (int i in RoomCanRent)
                {
                    if (i == roomNumber)
                    {
                        check = true;
                    }
                }
            }
            while (check == false);
            roomList[roomNumber - 1].Name = name;
            roomList[roomNumber - 1].Time = time;
            Console.WriteLine($"{roomList[roomNumber - 1].Type} Room {roomNumber} is Rented Now By Mr. {roomList[roomNumber - 1].Name}");
        }
        public void DisplayInfor()
        {
            for (int i = 0; i < roomList.Count; i++)
            {
                bool check = CheckStatus(i);
                if (check == true)
                {
                    Console.WriteLine($"{roomList[i].Type} Room {i + 1} is available");
                }
                else if (check == false)
                {
                    Console.WriteLine($"{roomList[i].Type} Room {i + 1} is rented by Mr. {roomList[i].Name} in {roomList[i].Time} Days");
                }
            }
        }
        public int PriceRoom(int roomNumber)
        {
            int price = 0;
            if (roomList[roomNumber - 1].Type == "Standard")
            {
                price = 200;
            }
            else if (roomList[roomNumber - 1].Type == "Vip")
            {
                price = 400;
            }
            else
            {
                price = 300;
            }
            return price;

        }
        public bool CheckData(int i)
        {
            bool check = true;
            if (roomList[i - 1].Name == null)
            {
                check = false;
                Console.WriteLine("No one rent that room!");
            }
            return check;
        }
        public int CalculateBill(int roomNumber)
        {
            int bill = roomList[roomNumber - 1].Time * PriceRoom(roomNumber);
            return bill;
        }
        public void DisplayBill()
        {
            int roomNumber;
            bool check;
            do
            {
                check = true;
                Console.Write("Pay for the room: ");
                roomNumber = int.Parse(Console.ReadLine());
                check = CheckData(roomNumber);
            } while (check == false);
            int bill = CalculateBill(roomNumber);
            Console.WriteLine($"You costed {bill}$ for rented {roomList[roomNumber - 1].Type} room for {roomList[roomNumber - 1].Time} days");
            roomList[roomNumber - 1].Name = null;
        }
        public void ChangeType()
        {
            Console.Write("What room u want to change type: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("type");
            string newtype = Console.ReadLine();
            roomList[roomNumber - 1].Type = newtype;
        }
        public void AddNewRoom()
        {
            Room room = new Room();
            Console.Write("Type of this room: ");
            room.Type = Console.ReadLine();
            roomList.Add(room);
        }
    }
}

