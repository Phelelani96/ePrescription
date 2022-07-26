namespace ePrescription.Data
{
    public class History_Medication
    {
        public int Id { get; set; }
        public int Medical_HistoryId { get; set; }
        public int MedicineId { get; set; }

        //Navigation Properties
        public Medical_History Medical_History { get; set; }
        public Medicine Medicine { get; set; }
    }
}
