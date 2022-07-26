﻿namespace ePrescription.Data
{
    public class Ingredients
    {
        public int Id { get; set; }
        public string Description { get; set; } = String.Empty;

        //Navigation Properties
        public ICollection<Med_Ingredients> Med_Ingredients { get; set; }
    }
}
