﻿using System.ComponentModel.DataAnnotations;

namespace ePrescription.Data
{
    public class Medicine
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(1, 100000000, ErrorMessage = "Please select Condition")]
        public int Dosage_FormId { get; set; }
        public string MedSizeId { get; set; } = string.Empty;
        [Range(1, 100000000, ErrorMessage = "Please select Condition")]
        public int ScheduleId { get; set; }

        //Navigation properties//
        public Dosage_Form? Dosage_Form { get; set; }
        public Schedule? Schedule { get; set; }
        //public MedSize Size { get; set; }
        public ICollection<Med_Ingredients>? Med_Ingredients { get; set; }
        public ICollection<Medical_History>? History { get; set; }
    }
}
