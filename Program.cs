using System.Net.Sockets;

var udpClient = new UdpClient(4009);

while (true)
{
    if (udpClient.Available != 0)
    {
        var result = await udpClient.ReceiveAsync();
        await udpClient.SendAsync(result.Buffer, result.RemoteEndPoint);
    }
}
