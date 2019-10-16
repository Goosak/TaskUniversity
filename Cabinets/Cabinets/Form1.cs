using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Cabinets
{
  

    public partial class fCabinets : Form
    {
        Lamp[] lamps;
        Drug[] drugs;
        FirstAidKit[] kits;
        Room[] rooms;

        public fCabinets()
        {
            InitializeComponent();
            lamps = new Lamp[4];
            lamps[0] = new Lamp("testMark", "testType", 56.67m, "qwerryy");
            lamps[1] = new Lamp("testMark1", "testType1", 60m, "qwerryy1");
            lamps[2] = new Lamp("testMark1", "testType2", 60m, "qwerryy2");
            lamps[3] = new Lamp("testMark3", "testType3", 100.56m, "Russia");

            drugs = new Drug[4];
            drugs[0] = new Drug("name1", "category1", 45.45m);
            drugs[1] = new Drug("aspirine", "category2", 10.5m);
            drugs[2] = new Drug("aezakmi", "category1", 45.45m);
            drugs[3] = new Drug("baguvix", "category3", 93.34m);

            Dictionary<Drug, string[]> kit1 = new Dictionary<Drug, string[]>();
            Dictionary<Drug, string[]> kit2 = new Dictionary<Drug, string[]>();
            string[] dataDrug = { "manufacturer1", "5" };
            string[] dataDrug2 = { "manufacturer3", "7" };
            kit1.Add(drugs[0], dataDrug);
            kit1.Add(drugs[1], dataDrug2);

            string[] dataDrug3 = { "manufacturer1", "3" };
            string[] dataDrug4 = { "manufacturer3", "10" };
            kit2.Add(drugs[2], dataDrug3);
            kit2.Add(drugs[3], dataDrug4);

            kits = new FirstAidKit[2];
            kits[0] = new FirstAidKit("first", kit1);
            kits[1] = new FirstAidKit("second", kit2);

            rooms = new Room[2];
            rooms[0] = new Room("201", lamps);
            rooms[1] = new Room("101", kits);

            cbRoom.Items.Add(rooms[0].Number);
            cbRoom.Items.Add(rooms[1].Number);

            outputLamps(lamps);

        }

        private void cbRoom_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbRoom.SelectedItem.ToString() == "")
            {
                gbRoomDetails.Visible = false;
            }
            else
            {
                outputRoomDetails(cbRoom.SelectedItem.ToString());

                gbRoomDetails.Visible = true;
            }
        }

        private void bCheckRooms_Click(object sender, EventArgs e)
        {
            Room[] emptyRooms = (from r in rooms where r.Kits.Count == 0 select r).ToArray();
            if (emptyRooms.Count() > 0)
            {
                StringBuilder listOfEmptyRooms = new StringBuilder("Кабинеты без аптечек:\n");
                foreach (Room r in emptyRooms)
                {
                    listOfEmptyRooms.Append(r.Number + "\n");
                }
                MessageBox.Show(listOfEmptyRooms.ToString());
            }
            else
            {
                MessageBox.Show("Все кабинеты укомплектованы аптечками");
            }
        }

        private void bCheckFirstAidKits_Click(object sender, EventArgs e)
        {
            FirstAidKit[] FAKs = (from fak in kits where fak.DrugsUsed.Count != 0 select fak).ToArray();
            if(FAKs.Count() > 0)
            {
                StringBuilder emptyFAK = new StringBuilder("Неполные аптечки:\n");
                foreach(FirstAidKit fak in FAKs)
                {
                    emptyFAK.Append(fak.Id+"\n");
                }
                MessageBox.Show(emptyFAK.ToString());
            }
            else
            {
                MessageBox.Show("Все аптечки в полной комплектации");
            }
        }

        private void bRussianLamps_Click(object sender, EventArgs e)
        {
            outputLamps((from l in lamps where l.Manufacturer == "Russia" select l).ToArray());
        }

        private void bAllLamps_Click(object sender, EventArgs e)
        {
            outputLamps(lamps);
        }

        private void вывестиДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dtLamp = new System.Data.DataTable();
            dtLamp.Columns.Add("lMark");
            dtLamp.Columns.Add("lNum");
            dtLamp.Columns.Add("lPrice");

            System.Data.DataTable dtDrug = new System.Data.DataTable();
            dtDrug.Columns.Add("ID");
            dtDrug.Columns.Add("lNum");
            dtDrug.Columns.Add("lPrice");

            Excel.Application exApp = new Excel.Application();
            exApp.Visible = true;
            exApp.Interactive = false;
            exApp.Workbooks.Add();
            Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
            workSheet.Cells[1, 1] = "Медикаменты";
            workSheet.Cells[2, 1] = "Наименование";
            workSheet.Cells[2, 2] = "Количество";
            workSheet.Cells[2, 3] = "Стоимость";
            int rowExcel = 3;
            
            for (int i = 0; i < drugs.Count(); i++)
            {
                workSheet.Cells[rowExcel, "A"] = drugs[i].Name;
                int count = 0;
                decimal price = 0;
                foreach(Room r in rooms)
                {
                    foreach(FirstAidKit kit in r.Kits)
                    {
                        int[] numbers = (from dk in kit.Drugs where drugs[i].Name == dk.Key.drugName select dk.Value).ToArray();
                        decimal[] prices = (from dk in kit.Drugs where drugs[i].Name == dk.Key.drugName select dk.Key.drugPrice).ToArray();
                        foreach (int n in numbers) count += n;
                        foreach (decimal pr in prices) price += pr;
                    }
                }
                workSheet.Cells[rowExcel, "B"] = count;
                workSheet.Cells[rowExcel, "C"] = price;
                rowExcel++;
            }
            rowExcel++;
            workSheet.Cells[rowExcel, 1] = "Лампы";
            rowExcel++;
            workSheet.Cells[rowExcel, 1] = "Маркировка";
            workSheet.Cells[rowExcel, 2] = "Конструктивный тип";
            workSheet.Cells[rowExcel, 3] = "Количество";
            workSheet.Cells[rowExcel, 4] = "Стоимость";
            rowExcel++;

            for (int i = 0; i < lamps.Count(); i++)
            {
                workSheet.Cells[rowExcel, "A"] = lamps[i].Mark;
                workSheet.Cells[rowExcel, "B"] = lamps[i].Type;
                int count = 0;
                decimal price = 0m;
                foreach (Room r in rooms)
                {
                    int numbers = (from l in r.Lamps where l.Mark == lamps[i].Mark && l.Type == lamps[i].Type select l).Count();
                    count += numbers;
                    decimal[] prices = (from l in r.Lamps where lamps[i].Mark == l.Mark && l.Type == lamps[i].Type select l.Price).ToArray();
                    foreach (decimal p in prices) price += p;
                    
                }
                workSheet.Cells[rowExcel, "C"] = count;
                workSheet.Cells[rowExcel, "D"] = price;
                rowExcel++;
            }

            exApp.Interactive = true;

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void outputLamps(Lamp[] lamps)
        {
            dgvLamps.Rows.Clear();
            foreach (Lamp lamp in lamps)
            {
                string[] lampRow = new string[4];
                lampRow[0] = lamp.Mark;
                lampRow[1] = lamp.Type;
                lampRow[2] = lamp.Manufacturer;
                lampRow[3] = lamp.Price.ToString();

                dgvLamps.Rows.Add(lampRow);
            }
        }

        public void outputRoomDetails(string numbRoom)
        {
            dgvRoomLamps.Rows.Clear();
            dgvFirstAidKits.Rows.Clear();
            Room currentRoom = (from r in rooms where r.Number == numbRoom select r).First();
            List<Lamp> roomLamps = currentRoom.Lamps;
            List<FirstAidKit> roomFAK = currentRoom.Kits;

            foreach (Lamp lamp in roomLamps)
            {
                string[] dr = new string[4];
                dr[0] = lamp.Mark;
                dr[1] = lamp.Type;
                dr[2] = lamp.Manufacturer;
                dr[3] = "Переместить";
                dgvRoomLamps.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }

            foreach (FirstAidKit kit in roomFAK)
            {
                Dictionary<DrugInKit, int> drugs = kit.Drugs;
                dgvFirstAidKits.Rows.Add(kit.Id, "", "", "", "Переместить");
                foreach (KeyValuePair<DrugInKit, int> drug in drugs)
                {
                    string[] dr = new string[5];
                    dr[0] = "";
                    dr[1] = drug.Key.drugName;
                    dr[2] = drug.Key.manufacturer;
                    dr[3] = drug.Value.ToString();
                    dr[4] = "Использовать";
                    dgvFirstAidKits.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
                }
            }
        }

        //перемещение аптечки
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbRoom.SelectedItem!=null)
            {
                Transport transport = new Transport();
                Transport.items = kits;
                Transport.rooms = rooms;
                Transport.parent = this;
                Transport.roomNumber = cbRoom.SelectedItem.ToString();
                Transport.trLamps = false;
                transport.Show();
            }
            else
            {
                MessageBox.Show("Выберите кабинет");
            }
        }

        //перемещение лампы
        private void button2_Click(object sender, EventArgs e)
        {
            if (cbRoom.SelectedItem!= null)
            {
                Transport.parent = this;
                Transport transport = new Transport();
                Transport.items = lamps;
                Transport.rooms = rooms;
                Transport.roomNumber = cbRoom.SelectedItem.ToString();
                Transport.trLamps = true;
                transport.Show();
            }
            else 
            {
                MessageBox.Show("Выберите кабинет");
            }
        }
    }

    public struct DrugInKit
    {
        public string drugName;
        public string manufacturer;
        public decimal drugPrice;
    }

    #region ObjectsDescription
    public class Lamp
    {
        private string mark;
        private string type;
        private decimal price;
        private string manufacturer;

        public string Mark
        {
            get { return mark; }
        }

        public string Type
        {
            get { return type; }
        }

        public decimal Price
        {
            get{ return price; }
        }

        public string Manufacturer
        {
            get { return manufacturer;  }
        }

        public Lamp(string mark, string type, decimal price, string manufacturer)
        {
            this.mark = mark;
            this.type = type;
            this.price = price;
            this.manufacturer = manufacturer;
        }
    }

    public class Drug
    {
        private string name;
        private string category;
        private decimal price;

        public string Name
        {
            get { return name; }
        }

        public string Category
        {
            get { return category; }
        }

        public decimal Price
        {
            get { return price; }
        }

        public Drug(string name, string category, decimal price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }
    }

    public class FirstAidKit
    {
        private string id;
        private Dictionary<DrugInKit, int> drugs;
        private Dictionary<DrugInKit, int> drugsUsed;

        public string Id
        {
            get { return id; }
        }

        public Dictionary<DrugInKit, int> DrugsUsed
        {
            get { return drugsUsed; }
        }

        public Dictionary<DrugInKit, int> Drugs
        {
            get { return drugs; }
        }

        public FirstAidKit( string id, Dictionary<Drug, string[]> drugs)
        {
            this.id = id; 
            this.drugs = new Dictionary<DrugInKit, int>();
            foreach(KeyValuePair<Drug, string[]> pair in drugs)
            {
                DrugInKit drug = new DrugInKit();
                drug.drugName = pair.Key.Name;
                drug.drugPrice = pair.Key.Price;
                drug.manufacturer = pair.Value[0];
                int num = Int32.Parse(pair.Value[1]);
                this.drugs.Add(drug, num);
                
            }
            drugsUsed = new Dictionary<DrugInKit, int>();
        }

        public void UseDrug(string drugName, string drugManufacturer)
        {
            DrugInKit usedDrug = (from dk in drugs.Keys where dk.drugName == drugName && dk.manufacturer == drugManufacturer select dk).First();
            if (drugsUsed.ContainsKey(usedDrug))
            {
                drugsUsed[usedDrug]++;
                drugs[usedDrug]--;
            }
            else
            {
                drugsUsed.Add(usedDrug, 1);
                drugs[usedDrug]--;
            }
        }

        public decimal CostDrugsForRefilling()
        {
            decimal cost = 0;
            foreach(KeyValuePair<DrugInKit, int> drug in drugsUsed)
            {
                cost += drug.Value * drug.Key.drugPrice;
            }
            return cost;
        }

        public void refill()
        {
            drugsUsed.Clear();
        }
    }

    public class Room
    {
        private string number; 
        private List<Lamp> lamps;
        private List<FirstAidKit> kits;

        public string Number
        {
            get { return number; }
        }
        public List<Lamp> Lamps
        {
            get { return lamps; }
        }
        public List<FirstAidKit> Kits
        {
            get { return kits; }
        }

        public Room(string number)
        {
            this.number = number;
            this.lamps = new List<Lamp>();
            this.kits = new List<FirstAidKit>();
        }

        public Room(string number, Lamp[] lamps)
        {
            this.lamps = new List<Lamp>();
            this.number = number;
            this.lamps.AddRange(lamps);
            this.kits = new List<FirstAidKit>();
        }

        public Room(string number, FirstAidKit[] kits)
        {
            this.kits = new List<FirstAidKit>();
            this.number = number;
            this.lamps = new List<Lamp>();
            this.kits.AddRange(kits);
        }

        public Room(string number, Lamp[] lamps, FirstAidKit[] kits)
        {
            this.lamps = new List<Lamp>();
            this.kits = new List<FirstAidKit>();
            this.number = number;
            this.lamps.AddRange(lamps);
            this.kits.AddRange(kits);
        }
    }

    #endregion
}
