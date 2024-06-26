﻿using tkpm_API.DTO.Request;
using tkpm_API.DTO.Response;

namespace tkpm_API.Services.Trips
{
    public interface ITripManager
    {
        Task<TripResponse?> GetTripById(int tripId);
        Task<TripBookingResponse?> GetLastestTrip();
        Task<TripBookingResponse> BookTrip(TripBookingRequest request);
        Task<bool> CancelTrip(int tripId);
        Task<bool> AcceptTrip(int tripId, int driverId);
        Task<bool> CompleteTrip(int tripId);
        Task<TripBookingResponse?> ValidatePickedUpTrip(int tripId);
    }
}
