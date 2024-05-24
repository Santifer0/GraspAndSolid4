//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class EquipmentCreator
    {
        public Equipment equipment;
        public EquipmentCreator(string description, double hourlyCost)
        {
        Equipment equipment = new Equipment(Description,hourlyCost);
        this.equipment = equipment;
        }

        public string Description { get; set; }

        public double UnitCost { get; set; }
    }
}