namespace LabEquipmentApi.Contracts
{
    public class EquipmentListItemResponse
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Room { get; set; }
    }
}
