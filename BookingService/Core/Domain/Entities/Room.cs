namespace Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public bool InMaintenance { get; set; }
        public bool isAvailable
        {
            get
            {
                if(this.InMaintenance || this.HasGuest)
                {
                    return false;
                }
                return true;
            }
        }
        public bool HasGuest {
            // Verificar se existem bookings abertos para esta room

            get { return true;  } 
        }
    }

}
