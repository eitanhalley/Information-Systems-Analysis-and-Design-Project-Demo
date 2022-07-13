using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD_20
{
    public class Equipment
    {
        private int equipmentID;
        private WorkshopEquipment workShopEquipment;
        private int quantity;
        private int activityID;

        public Equipment(int equipID, WorkshopEquipment name, int num, int activityID)
        {
            this.equipmentID = equipID;
            this.workShopEquipment = name;
            this.quantity = num;
            this.activityID = activityID;
        }

        //Getters
        public int get_equipmentID()
        {
            return this.equipmentID;
        }
        public WorkshopEquipment get_workShopEquipment()
        {
            return this.workShopEquipment;
        }
        public int get_quantity()
        {
            return quantity;
        }
        public int get_activityID()
        {
            return activityID;
        }
        
        //Setters
        public void set_equipmentID(int id)
        {
            this.equipmentID = id;
        }
        public void set_workShopEquipment(WorkshopEquipment equip)
        {
            this.workShopEquipment=equip;
        }
        public void set_quantity(int num)
        {
            this.quantity=num;
        }
        public void set_activityID(int id)
        {
            this.activityID=id;
        }
    }
}
