using Bit.BlazorUI;

namespace BitCareers.Client.Pages
{
    public partial  class Index
    {
        private BitCarousel ?carousel;

        private void GoNext() => carousel?.GoNext();
    }
}
