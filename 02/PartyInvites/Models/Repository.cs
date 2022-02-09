using System.Collections.Generic;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();
        
        public static IEnumerable<GuestResponse> Responses { get { return responses; } } // возвращаем IEnumerable вместо List для защиты от изменения другими частями программы

        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
