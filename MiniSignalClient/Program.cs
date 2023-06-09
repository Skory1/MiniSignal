﻿using Microsoft.AspNetCore.SignalR.Client;

const string url = "https://localhost:7092/chat";

await using var connection = new HubConnectionBuilder()
    .WithUrl(url)
    .Build();

await connection.StartAsync();

await foreach (var date in connection.StreamAsync<DateTime>("Streaming"))
{
    Console.WriteLine(date);
}

