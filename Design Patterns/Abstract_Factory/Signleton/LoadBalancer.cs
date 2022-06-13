namespace Singleton;

public class LoadBalancer {
    static LoadBalancer instance;
    List<string> servers = new List<string>();
    Random random = new Random();

    private static object locker = new object();

    protected LoadBalancer() {
        servers.Add("ServerI");
        servers.Add("ServerII");
        servers.Add("ServerIII");
        servers.Add("ServerIV");
        servers.Add("ServerV");
    }

    public static LoadBalancer GetLoadBalancer() {
        if (instance == null) {
            lock (locker) {
                if (instance == null) {
                    instance = new LoadBalancer();
                }
            }
        }
        return instance;
    }

    public string Server {
        get {
            int r = random.Next(servers.Count);
            return servers[r].ToString();
        }
    }
}