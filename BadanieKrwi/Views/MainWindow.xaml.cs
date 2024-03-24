using BadanieKrwi.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace BadanieKrwi.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int[] inty = { 10, 9, 8, 5, 7, 2, 3, 4, 1, 6 };
            Sort(inty);
        }

        private void Sort(int[] arr)
        {
            int n = arr.Length;

            // Budowanie kopca (przeorganizowanie tablicy)
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            // Jeden po drugim ekstraktujemy elementy z kopca
            for (int i = n - 1; i >= 0; i--)
            {
                // Przenieś obecny korzeń na koniec
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // wywołaj procedurę heapify na zmniejszonym kopcu
                Heapify(arr, i, 0);
            }
        }

        /// <summary>
        /// To heapify a subtree rooted with node i which is an index in arr[]. n is size of heap.
        /// </summary>
        /// <param name="arr">Array to heapify.</param>
        /// <param name="n">Size of heap.</param>
        /// <param name="i">Index of root element of the subtree.</param>
        private void Heapify(int[] arr, int n, int i)
        {
            int largest = i; // Inicjalizacja największego jako korzeń
            int left = 2 * i + 1; // lewy = 2*i + 1
            int right = 2 * i + 2; // prawy = 2*i + 2

            // Jeśli lewy dziecko jest większe niż korzeń
            if (left < n && arr[left] > arr[largest])
                largest = left;

            // Jeśli prawe dziecko jest większe niż największy dotychczas
            if (right < n && arr[right] > arr[largest])
                largest = right;

            // Jeśli największy nie jest korzeniem
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Rekurencyjnie heapify dotkniętą poddrzewo
                Heapify(arr, n, largest);
            }
        }

        private void inputHaslo_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainWindowViewModel vm && sender is PasswordBox pb)
            {
                vm.Haslo = pb.Password;
            }
        }
    }
}
