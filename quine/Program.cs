namespace Quine {
    public class Quine {
        public static void Main(string[] args) {
            var s = new[] {
"namespace Quine {", "    public class Quine {", "        public static void Main(string[] args) {", "            var s = new[] {", "            for (var i = 0; i < 4; i++ ) System.Console.WriteLine(s[i]);", "            System.Console.Write((char)34 + string.Join(System.Text.Encoding.ASCII.GetString(new byte[] {34, 44, 32, 34}) , s) + System.Text.Encoding.ASCII.GetString(new byte[]{34, 32, 125, 59, 13, 10}));", "            for (var i = 4; i < s.Length; i++) System.Console.WriteLine(s[i]);", "        }", "    }", "}" };
            for (var i = 0; i < 4; i++ ) System.Console.WriteLine(s[i]);
            System.Console.Write((char)34 + string.Join(System.Text.Encoding.ASCII.GetString(new byte[] {34, 44, 32, 34}) , s) + System.Text.Encoding.ASCII.GetString(new byte[]{34, 32, 125, 59, 13, 10}));
            for (var i = 4; i < s.Length; i++) System.Console.WriteLine(s[i]);
        }
    }
}
