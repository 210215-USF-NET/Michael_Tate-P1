using StoreModels;
using StoreMVC.Models.PatronModel;

namespace StoreMVC.Models
{
    public interface IMapper
    {
        Patron Cast2CreatePatron(CreatePatron newPatron);

        Patron Cast2Index(Patron currentPatrons);

        Patron Cast2Details(PatronDetailModel patronDetails);
    }
}