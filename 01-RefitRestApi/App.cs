using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RefitRestApi {
internal class App {
    internal async Task Start(IHost host) {
        IUsersClient usersClient = host.Services.GetRequiredService<IUsersClient>();
        IEnumerable<User> users = await usersClient.GetAll();

        foreach (var user in users) {
            Console.WriteLine(user);
        }
    }
}
}
