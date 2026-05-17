namespace CarDealership.Services
{
    // Сервіс для отримання індексу вибраного рядка у DataGridView
    public class MatchSelectionService
    {
        public int GetSelectedIndex(DataGridView grid)
        {
            if (grid.SelectedRows.Count == 0)
                return -1;

            return grid.SelectedRows[0].Index;
        }
    }
}