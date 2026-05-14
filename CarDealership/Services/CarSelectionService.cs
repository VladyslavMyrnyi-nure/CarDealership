namespace CarDealership.Services
{
    public class CarSelectionService
    {
        public Guid GetSelectedId(DataGridView grid)
        {
            if (grid.SelectedRows.Count == 0)
                return Guid.Empty;

            return (Guid)
                grid.SelectedRows[0].Cells["Id"].Value;
        }
    }
}