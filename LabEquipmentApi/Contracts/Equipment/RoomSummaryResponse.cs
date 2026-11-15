namespace LabEquipmentApi.Contracts.Equipment
{
    public class RoomSummaryResponse
    {
        public required string Room { get; set; }
        public required int TotalCount { get; set; }
        public required int AvailableCount { get; set; }
    }
}
