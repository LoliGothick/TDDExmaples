﻿namespace TDDExmaples
{
    class Test
    {
        // TODO 規則 1：4 で割り切れる年はうるう年である。
        // TODO 規則 2：100 で割り切れる年をうるう年ではない。
        // TODO 規則 3：400 で割り切れる年はうるう年である。
        // TODO 規則 4：規則 1〜3 のいずれも満たさない場合は，うるう年ではありません。
        // 備考：規則 1 〜 3 の内に複数満たすものがあれば後の規則（数字の大きな規則）が優先されます。
        public static string IsLeap(int a)
            => a % 4 == 0 ? "YES" : "NO";
    }
}
