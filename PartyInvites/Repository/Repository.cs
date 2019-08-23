using System.Collections.Generic;
using PartyInvites.Models;

namespace PartyInvites.Repository
{
    public static class MayRepository
    {
        static MayRepository()
        {
            Responses = new List<GuestResponse>();
        }
        public static List<GuestResponse> Responses { get; }

        public static void AddResponse(GuestResponse response)
        {
            Responses.Add(response);
        }
    }
}