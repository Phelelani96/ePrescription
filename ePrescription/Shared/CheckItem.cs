namespace ePrescription.Shared
{
    public class CheckItem
    {
        public CheckItem()
        {

        }
        public CheckItem(int id, string name, bool ischecked)
        {
            Id = id;
            Name = name;
            IsChecked = ischecked;
        }
        public CheckItem(int id, string name, string strength, bool ischecked)
        {
            Id = id;
            Name = name;
            Strength = strength;
            IsChecked = ischecked;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Strength { get; set; }
        public bool IsChecked { get; set; }
    }
}
