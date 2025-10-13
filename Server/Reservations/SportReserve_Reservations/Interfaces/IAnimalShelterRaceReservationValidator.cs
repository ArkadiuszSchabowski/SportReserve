using SportReserve_Shared.Models.Race;
using SportReserve_Shared.Models.Reservation.Add;

namespace SportReserve_Reservations.Interfaces
{
    public interface IAnimalShelterRaceReservationValidator
    {
        void ValidateAnimalShelterRaceReservation(AddAnimalShelterRace reservation, GetRaceDto getRaceDto, GetRaceTraceDto getRaceTraceDto, string userId, string userIdFromToken);
    }
}
