using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinets
{
    public partial class Transport : Form
    {

        public static object[] items;
        public static fCabinets parent;
        public static Room[] rooms;
        public static string roomNumber;
        public static bool trLamps = false;
        public Transport()
        {
            InitializeComponent();
        }

        private void Transport_Load(object sender, EventArgs e)
        {
            if (trLamps)
            {
                lChoose.Text = "Выберите лампу";
                Lamp[] lamps = (Lamp[])items;
                Room room = (from r in rooms where r.Number == roomNumber select r).First();
                cbChoose.Items.AddRange((from l in room.Lamps select l.Mark).ToArray());
            }
            else
            {
                lChoose.Text = "Выберите аптечку";
                FirstAidKit[] lamps = (FirstAidKit[])items;
                Room room = (from r in rooms where r.Number == roomNumber select r).First();
                cbChoose.Items.AddRange((from k in room.Kits select k.Id).ToArray());
            }

            string[] roomsNums = (from r in rooms where r.Number != roomNumber select r.Number).ToArray();
            cbNewRoom.Items.AddRange(roomsNums);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Room newRoom = (from r in rooms where r.Number == cbNewRoom.SelectedItem.ToString() select r).First();
            Room oldRoom = (from r in rooms where r.Number == roomNumber select r).First();
            if (trLamps)
            {
                Lamp[] lamps = (Lamp[])items;
                Lamp lamp = (from l in lamps where l.Mark == cbChoose.SelectedItem.ToString() select l).First();
                newRoom.Lamps.Add(lamp);
                oldRoom.Lamps.Remove(lamp);
                parent.outputRoomDetails(roomNumber);
                this.Close();
            }
            else
            {
                FirstAidKit[] kits = (FirstAidKit[])items;
                FirstAidKit kit = (from f in kits where f.Id == cbChoose.SelectedItem.ToString() select f).First();
                newRoom.Kits.Add(kit);
                oldRoom.Kits.Remove(kit);
                parent.outputRoomDetails(roomNumber);
                this.Close();
            }
        }
    }
}
