using LibraryData.Models;
using System.Collections.Generic;
using System;

namespace LibraryData
{
    public interface ICheckout
    {
        IEnumerable<Checkout> GetAll();
        Checkout GetById(int checkoutId);
        void Add(Checkout newCheckout);
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        void PlaceHold(int assetId, int libraryCardId);
        void CheckoutItem(int assetId, int libraryCardId);
        void CheckInItem(int assetId);
        Checkout GetLatestCheckout(int assetId);
        int GetNumberOfCopies(int id);
        int GetAvailableCopies(int id);
        bool IsCheckedOut(int assetId);
        string GetCurrentCheckoutPatron(int assetId);

        string GetCurrentHoldPatronName(int id);
        DateTime GetCurrentHoldPlaced(int id);
        string GetCurrentPatron(int id);
        IEnumerable<Hold> GetCurrentHolds(int id);

        void MarkLost(int assetId);
        void MarkFound(int assetId);
    }
}
