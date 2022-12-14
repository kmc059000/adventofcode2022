module AoC2022.Inputs

open System

module Day01 =
    let day01sample = "1721
    979
    366
    299
    675
    1456"

    let day01 = "1834
    1546
    1119
    1870
    1193
    1198
    1542
    1944
    1817
    1249
    1361
    1856
    1258
    1425
    1835
    1520
    1792
    1130
    2004
    1366
    1549
    1347
    1507
    1699
    1491
    1557
    1865
    1948
    1199
    1229
    1598
    1756
    1643
    1306
    1838
    1157
    1745
    1603
    1972
    1123
    1963
    1759
    1118
    1526
    1695
    1661
    1262
    1117
    1844
    1922
    1997
    1630
    1337
    1721
    1147
    1848
    1476
    1975
    1942
    1569
    1126
    1313
    1449
    1206
    1722
    1534
    1706
    1596
    1700
    1811
    906
    1666
    1945
    1271
    1629
    1456
    1316
    1636
    1884
    1556
    1317
    1393
    1953
    1658
    2005
    1252
    1878
    1691
    60
    1872
    386
    1369
    1739
    1460
    1267
    1935
    1992
    1310
    1818
    1320
    1437
    1486
    1205
    1286
    1670
    1577
    1237
    1558
    1937
    1938
    1656
    1220
    1732
    1647
    1857
    1446
    1516
    1450
    1860
    1625
    1377
    1312
    1588
    1895
    1967
    1567
    1582
    1428
    1415
    1731
    1919
    1651
    1597
    1982
    1576
    1172
    1568
    1867
    1660
    1754
    1227
    1121
    1733
    537
    1809
    1322
    1876
    1665
    1124
    1461
    1888
    1368
    1235
    1479
    1529
    1148
    1996
    1939
    1340
    1531
    1438
    1897
    1152
    1321
    1770
    897
    1750
    1111
    1772
    1615
    1798
    1359
    1470
    1610
    1362
    1973
    1892
    1830
    599
    1341
    1681
    1572
    1873
    42
    1246
    1447
    1800
    1524
    1214
    1784
    1664
    1882
    1989
    1797
    1211
    1170
    1854
    1287
    1641
    1760"


module Day02 =
    let sample = "1-3 a: abcde
    1-3 b: cdefg
    2-9 c: ccccccccc"

    let mainInput = "4-5 t: ftttttrvts
    7-8 k: kkkkkkkf
    4-6 k: gqjkkk
    1-2 t: rttb
    7-10 z: gzjtmtcrzv
    5-13 g: cgbmglsdwwlhqk
    7-8 t: ttttttttt
    3-4 d: xnbx
    3-5 n: nznnnnf
    7-10 q: kqhcqqqqqqqqn
    11-12 c: qccccccccczk
    5-6 m: mmkmmm
    3-4 m: mmll
    9-11 p: pppppppprpppppp
    5-9 j: jbljjjjjjljj
    9-14 r: rrrrrrkrrrcrrrr
    1-9 f: fxtgcfqncz
    2-5 c: jcgcj
    11-14 b: bbbbbbbbbbbbbbb
    5-6 w: wwwwnm
    1-9 s: pcjjshfjsqksfkwrzpc
    9-12 z: zzzzzlzzmszvz
    3-6 d: ltfddb
    4-6 q: qlgqsc
    3-6 m: rchbzmkpgmmsbfmxx
    1-4 q: qsqqk
    1-4 x: pxch
    6-12 c: czccjccdxvnck
    1-9 v: bxvvvvvvclvv
    9-14 q: qqqqsqqhszqqqdqkq
    5-6 c: cccccccc
    7-10 w: wwhkzgwwwbr
    4-11 r: wqnftvtptgrsj
    15-16 d: dddddddddndddddj
    4-8 l: lltllllll
    3-4 r: krqk
    8-10 x: xxlmmxcxdg
    9-12 p: pppxpsppmmdppmpp
    1-7 g: gdhmblk
    6-8 l: lllllllll
    6-7 c: hccxctcjcc
    3-4 c: ccrq
    7-11 c: hhznqncwwcx
    10-16 z: vwxbktbxlztcptkzrmc
    3-4 v: vvvv
    5-11 t: ftnntttttqt
    4-6 g: gqgzpp
    12-13 p: ppppppppppppphd
    12-14 h: hhhhhhhhhhhhhh
    3-4 f: srkbk
    7-8 d: ddkdvrrpwddc
    8-11 d: zdrmqdplddddkwdfkddd
    5-7 s: sjdtrpj
    10-11 b: bbbbbdbbbbbb
    7-15 m: mmmmmmmmmmmmmmmm
    2-4 h: pmhzcstpm
    8-11 m: vfmbmqsmtsm
    4-7 n: wcvnnrnsnkqtsnvk
    2-7 s: bsmcnvsvs
    3-7 h: hhqchhnzh
    6-10 x: rxxxqnrklcjbblkhldcv
    5-8 p: pppppppp
    12-20 v: gvvgvmvhkvvghzrkhmwm
    8-15 w: wwwwkwfrwvwwwqhwwww
    1-4 h: hdhh
    17-18 f: fbffffffffbfxfflsx
    2-5 g: kgfjg
    6-10 s: sjsssssssbss
    1-11 p: fpppppspppxpp
    9-12 s: zsxgdmssssfps
    5-12 f: ftffflffffwnfz
    5-6 z: zzzvccggzz
    4-5 f: fffxg
    9-11 c: fcccpchccccsplfdxcc
    1-8 z: gzzsztvzrzzzzz
    3-8 w: vwwwwrbw
    5-6 s: ssssmm
    13-15 p: cppppppppppppppp
    7-14 n: mvxbsjnngkrzxnpnc
    6-14 h: brlswhnccjcjhhtd
    7-14 r: sbsrrprrvlhrrr
    7-12 h: hhhhnwphhhhphhhkznhh
    3-4 v: vvvs
    11-12 p: ttpvphprpzrrwp
    9-11 l: lllhllljhlr
    7-20 x: xxqdzbxmdmsxxpxqxqxx
    5-9 t: jvtnqgjvpblrqt
    10-11 b: mbbbbbbbbbbb
    5-6 p: phpphd
    1-4 q: qgqq
    2-9 b: mbbbbvbbtbmbw
    1-3 j: tldcjcjm
    2-4 l: lnlll
    11-12 q: qqqqqqqqqqfq
    2-5 x: gxgfxcfhnbgxzxzntpp
    6-11 d: tddddpddddd
    6-13 s: hnsgjsbdrsmsxnpgc
    7-11 v: vvllhvnrrvg
    15-17 k: kkkkkkkkkkkkkkkkw
    6-8 w: nrwwvwmc
    3-4 s: sdgs
    1-7 g: ggzhnggcf
    6-16 w: wdzwhwtjnwcvxlwwww
    12-15 s: ssssssszsshxssbfs
    7-8 v: jpvsbvvvx
    18-19 v: vvvvcvvvsfmvfmzxdvcv
    2-6 h: qdlhcg
    4-15 m: mmmmmmmmmmmmmmmm
    2-5 s: hrssmjps
    10-12 c: rccdcchccvcqcccccjc
    17-20 r: rrfrdgnrrrkdrrrvrqnl
    4-6 w: rkmwww
    5-6 p: pdhphcq
    7-13 b: bjbbzrbbbbbbbb
    16-17 v: svvvvwvqvvvkwmvvvvvv
    4-8 h: dqhgtkhhfhdh
    16-18 r: ttjtbfhrrsgnnnjrmr
    5-9 n: xwnxdspnwnnn
    7-9 t: hhtttbqnt
    12-13 j: jjjjjjjjjjjzjjjjjj
    15-17 p: pxpppppppppppplph
    17-18 c: vcccccccccccccczcc
    5-10 j: jjjjjbjjjj
    1-13 x: nxxwmxxxpxxkdxhxx
    11-14 z: zzzzzzlrzzzzzk
    1-2 s: tcsbn
    3-4 p: pphd
    6-7 r: rrrrrcrrrhr
    5-13 z: hczzlzzdzvxjztbgxzzz
    8-10 j: mjnjjncjtj
    5-8 s: ssssqssc
    2-5 t: httgpttstttdttttttt
    2-3 x: jfxmxwx
    4-7 x: xwkcxfxxx
    2-9 w: zwpjnwnhwdh
    12-14 q: qqqqqqqqqqqtql
    8-10 g: gggggggggw
    3-4 t: jtztc
    4-6 g: ggggkgvgvg
    2-3 g: qgggzg
    3-5 n: nxpnzn
    13-18 c: ccccncmccccctccccm
    12-18 b: bbbbbbbbbbbbbbgbbbb
    3-18 z: jhwspcbstmdfzxmgwz
    2-6 v: scvvvl
    2-10 p: bpvpzpttvwzpkrrr
    6-7 v: vvvvvvv
    6-9 h: thshdhtwhrkqcxc
    5-6 l: llslllgzll
    4-14 k: kkkkkkkkkkkkkhkk
    3-9 r: rrjrrrrrt
    2-13 x: xxxxxxxxxxxxwxx
    12-15 m: fvbgmxhrxmqwzmdmd
    3-15 c: ccfccccrccccctcccc
    6-10 b: cbbjqrgpvcnnnz
    8-9 z: zzzzzzzpj
    2-7 m: mmmmmmwmmmqmmmmmmm
    6-15 g: gggggqggggggggsgd
    6-7 t: gmttvtt
    15-18 v: wvvmvvvvvvvvvvvvvvvv
    8-9 t: ttbpftjtttvttttt
    10-14 b: xwzvbbbbbbbxbcq
    3-4 n: nffsjnqbntlbg
    2-8 z: zszzzzzgzz
    2-4 l: klzf
    8-11 r: rrrnrrrsrrrrr
    14-17 w: wwmwwwwwwwwwhkwwwws
    6-7 v: vvvvvlg
    3-5 h: hhhhzhfhhh
    4-5 q: whkbfhnnqtpsnn
    2-3 w: whgv
    3-5 z: jzdzc
    4-6 g: ggdnggjgqnn
    1-15 m: dwljbfnxwtpnhsmm
    1-5 k: tkkkfkkk
    14-15 x: xxxxxxxxxxxxxtbx
    8-11 d: hnqngfddnrdr
    1-6 t: bttmtttttk
    2-6 f: fffffpf
    7-12 m: mmmmmmmmmmmmm
    1-8 t: httttstgcttg
    5-6 q: qqbqqqq
    7-8 h: vhhhhhhgh
    5-12 x: dqkllgbtbrnqxgxvmj
    1-2 d: rzrdl
    6-7 k: jvkkkvkkk
    2-3 q: qdjqqqqq
    10-12 k: xkkkgkkrvpkkzkkkl
    2-4 g: srgmw
    6-7 j: jjjjjzjv
    13-14 s: sssssvsssssspk
    4-9 x: smcxncxdxvjx
    18-19 w: pwwpwwbxzwkrmxdwttkb
    1-13 t: xbjctvkqqpwjkfdwmqq
    4-9 r: rrrxrrrrrr
    7-11 c: ncccclcccckc
    15-16 p: hppgpnpdpwpppppp
    7-12 m: bmvmmmrmpvmckmm
    4-6 n: nznzqm
    1-7 x: klxxpxjxnxxxslxx
    5-6 t: ttttpz
    5-12 k: kncktrgkkkkskxfkw
    3-4 x: xdvd
    4-5 m: mmmmm
    11-12 x: xxcfxxfxxxhrxfxr
    17-18 j: jjjjjjjjjjjjjjjjjjjj
    5-8 d: ddddddddd
    5-6 h: hmhhhhgp
    5-10 b: bggkjlbrbstb
    3-4 g: ggql
    4-6 k: bkkkkk
    12-15 v: vvkcvvvvvvvvvvk
    7-9 h: hhhhhnlhb
    7-8 d: sfxdddrzddd
    2-3 m: jmcb
    6-7 q: qqqqqqqqpq
    3-17 g: kwgggjsgldglhgvggqx
    17-19 r: rrrrrrrrrrrrrrrrxrjr
    5-11 w: wxvhwtwwwwwxw
    6-7 g: gggggggggggg
    3-4 w: wbfrw
    3-10 m: mmmmmmmltmmmm
    4-6 q: gqbgwddqqqrqqbqq
    4-5 b: bmbzm
    4-6 r: trmrrrr
    3-5 k: kkkkk
    9-13 k: sxvklkbkqfktk
    4-8 t: jxjtttttxvv
    1-4 x: twzxxx
    3-8 q: nfqqqqpqmqq
    11-12 q: qqqqqqqqqqqqqqq
    9-16 l: llllllllllllllll
    8-12 n: vrwwxnnnnnnr
    12-18 t: tttttttttltzttstrt
    2-6 q: bqmgqqq
    2-11 j: tjjjjjjjjjjjjjjx
    7-10 g: ggggggggfqg
    3-11 m: mmtmpmffmmpmmmrmpm
    11-15 c: cmzcccchxcdccccc
    1-14 j: jxvptjlcjvphxj
    4-5 m: zmvmmzmxkm
    3-4 m: zxtr
    13-14 w: fmbwhmwfsdknvv
    5-8 s: sswsssls
    7-12 d: dddfddddzdddddddhdd
    4-15 t: tnttntthtttttctt
    14-17 v: gtcvvvsvgwvvhllvszn
    15-17 z: zzzzzzzzzzzzzzgzzzz
    2-3 p: wpptpkclprpnmqzrb
    8-10 p: tppkcpgjppprpp
    3-6 j: jjjjdjj
    4-8 h: gbhckclnpm
    17-18 j: jjjjjbjjjjjwjjjjfwj
    12-13 f: ffffffffffzfq
    2-7 b: lbcwbwbbbx
    11-17 h: hzhhzghfhhxhhchhkkb
    11-12 j: jjjjjjjjjjxj
    11-17 l: vsljlllllllmlnljzltl
    3-5 h: hhlhrshk
    6-12 k: kkkkkvkkkkkr
    3-5 q: qqwwqwq
    3-10 q: qzqqlqpclq
    10-12 v: vvsvpvcvvvbvvvv
    4-6 g: lkvnrng
    2-5 t: ttttf
    7-8 p: ppppppppb
    16-19 v: vvvvgvjvvvvvvvvvvvw
    1-5 m: mpqdmmnsgrbhmsr
    3-4 h: qhhwh
    3-5 l: kllfl
    3-4 j: jjsj
    8-13 b: xfnbzclcbgbrbnqfxqb
    8-14 s: ssssssssssssssss
    6-8 d: ddndwgds
    5-6 n: npnwnnltsqwvqkqnnmn
    3-10 q: dqvpqgqbrtqqqq
    5-6 l: llllrml
    1-14 w: kwwwwpwwwhwrwwwmzpw
    17-18 c: cccpcmccccccccccsnnc
    2-6 f: xftpfhg
    8-9 q: qgqqqqqmkq
    4-6 x: xxxxxx
    3-4 b: brbb
    12-14 s: mscswnvczsxqss
    4-7 g: gqggggg
    6-15 x: xxxxxgxxxxxxxxsx
    8-13 w: dfjdnwpjsqglh
    8-11 s: sssssssssssss
    17-18 g: ggggggggggggggggggg
    1-5 v: vvvvv
    4-10 l: lllpzlllnxll
    2-3 m: mpmmj
    8-15 d: xdfqzlsdwmkwsdddjdxd
    5-12 t: ttntgthtttthttt
    1-7 w: xwwtwwvwwbwwwpwswwww
    8-13 n: nnnnngnldnqnvnj
    9-10 f: tfffhvfrffhffff
    5-7 c: cccmcccmvjf
    5-9 v: kpxscvptvv
    1-5 l: vxqsl
    1-2 k: kkvbkvld
    11-15 p: ppppppzppprpwplb
    9-11 w: wwswwzdkwwwwwpsw
    1-12 v: tvvvvvvvvvvnvvvvv
    15-18 v: vbvkgvfcstjvxnqvfnv
    6-11 z: tzzjzvzzzzd
    2-7 d: ddddddddddddddddddd
    15-16 t: kvmjvtqbtvttbrbthg
    14-16 l: qnlllllllllllmlr
    8-11 l: llllcllllls
    12-13 c: spcdfcccczcclc
    4-5 m: fmmftf
    5-7 w: bqpwpnw
    4-5 b: bwcbbcv
    1-12 j: jjjjjjjjvjjjjjjj
    1-10 r: rrrrrrrrrn
    2-3 q: gqqqpq
    1-2 g: rhbpbhcxgnt
    3-5 m: mmmmm
    3-8 p: nzsmpqwjqd
    9-11 f: fdwwfwxkfzkvbf
    5-7 x: vzxxfxqxmvx
    4-7 x: xcxjxxx
    4-9 j: jjjqjjjjnj
    4-5 c: cdcdcscf
    3-6 l: slkwnqlnlllqlplxll
    3-5 n: nnnwnftn
    16-17 b: bbbbbbbbdbbbbbbbr
    3-5 h: wjchqk
    6-8 j: jjjjhmjj
    4-8 s: sgqsbkhc
    8-11 x: wzwjxxnjmxlqj
    2-3 f: fjdqcf
    6-12 n: nnjnnnnnnnnn
    15-17 b: bbbbbbbbpbbbfbbbb
    1-2 r: rrkr
    5-9 s: jhsklssss
    4-5 r: grrfd
    3-5 n: nnznknn
    6-7 t: rtttdttjptq
    17-19 v: cbvvvksvtfzcpvbrvkv
    5-9 s: bppqshpspbfqx
    2-10 l: llwkstkvrlprplmd
    5-10 c: ptfhcgpcfc
    6-8 g: gmgtxggggzgcjg
    9-11 m: mmmfsfmcmsmpmmmmrm
    2-7 v: gvgvqlvvvzk
    11-15 h: hgfhhbhfnqhnfhpnzh
    11-12 k: kftkklkkqlknckk
    5-10 z: zzzzgzzzzd
    13-18 h: hhghhhhhhhhjwhhhhch
    7-8 d: ddtjddcdrdzddz
    2-5 x: xxxxxh
    3-4 s: ssxss
    16-17 j: jjjjjjwjjjjjjhntfjjj
    10-14 v: vjknknwqfvrkcvlnh
    6-9 z: gvzszvzzzz
    2-4 g: kggg
    1-3 c: hcbr
    8-11 p: pzpppppprpp
    19-20 x: xxxnxxxxxxxxxxxxxxrn
    5-8 t: tttqjqtrt
    1-3 q: fcxzhf
    1-5 m: mmmmm
    7-12 m: mmmmmmgmmmmbm
    11-15 s: snsbshsssksssss
    11-13 g: ggggngszgrdgngggdg
    11-14 c: ccccccvdccghcxlccnc
    3-5 s: dsfsxs
    8-10 v: mvvvpvvvrv
    3-8 q: qqqsqqqqwqpqql
    1-6 d: lddddmdddd
    3-9 g: nrrxtpntgwxjx
    11-12 m: mmmmzmmmmmmlmml
    5-10 x: bxqxzxzxxl
    1-2 w: dspwwmgwqwwwccww
    6-7 j: jjjjjjj
    7-8 h: nnhhwhlh
    10-15 w: zqqwwwzwpwwwwwnwwwww
    6-14 m: zmzdsmlxfhmxmvl
    4-7 x: xrftnvfxpw
    7-14 b: bbkqbbgpbbbwjcb
    3-4 b: bblmb
    12-19 h: hshqhhhhhhdhxhhhhhh
    1-9 h: hhhhhhhhzhbh
    14-16 h: mhpfvnhjhhfhphdj
    3-4 t: tttt
    3-6 s: dkspsssgs
    1-5 w: tgfwbgwhz
    4-7 f: snfsxwr
    7-12 x: xxxxcxlxxxtrnx
    1-3 b: djbbgb
    5-6 j: rrmjkwjgvjj
    3-11 v: vvvvvvvvvvrv
    16-17 g: wrwgsggmkjfvsbgvg
    10-13 d: ddddddkddddddd
    7-10 d: lldfcpmzgrjvdmlg
    12-14 w: jwlndwtwwnwbvl
    7-12 b: pbfbkdbbbsbb
    16-18 h: hkhghhhhhhhhhhhhhhhh
    2-13 h: rhcqxkxjvjxfhhx
    13-16 n: nnnnnnnnnnnnvnnqn
    4-7 k: tkkkksk
    4-9 m: mcmmpnsmm
    9-17 f: hffffffrpxfftjfxkfdq
    1-6 g: fggggxg
    3-4 f: fpfhp
    8-14 c: ftbcslflhqccff
    10-15 x: xxxvxxhxxxxzxbwxxxx
    4-5 w: lwwwwwn
    6-7 g: vgqsgwg
    11-13 m: mmncmjmmlmmmkmmm
    13-15 r: jrrrrrrrrrrrzrr
    2-7 x: hxxqttklmmfbrtr
    5-6 d: sddhddd
    2-9 h: jmhnrxhhjqs
    4-6 x: xcxtpz
    1-9 c: ccccccrck
    1-3 s: ssss
    5-10 g: kknxxflghqpgn
    10-11 p: ppppppppppp
    6-8 v: vvvvvdcznv
    10-13 l: ftlcntpzqrdprlclhll
    6-7 x: cxxxxxxxw
    16-17 b: lbbbbbbbbbbbbbbbb
    4-7 b: bbbbbbj
    7-11 r: chjbrxncqzgzkj
    10-11 j: jjjjkhjjjjjjjjjj
    4-5 h: hhhhh
    15-16 c: cccccmccccccccsf
    6-10 v: lvvvvhvfvx
    10-16 h: dhhhhvhchqhhhhhhhhhp
    2-5 v: vqnvc
    6-9 r: rhmrgrrgbwmzrrjjr
    1-6 b: bbbbbll
    17-18 q: bqqqqqqqrqqqqqsqqqqq
    6-9 s: kbxscssssssssswgss
    2-7 f: tvfvzfkf
    5-15 l: bxllhlcllllllllqmmb
    17-19 p: ppppthppppppppppppp
    14-16 n: nlkhnnnwnngnrnnnn
    3-15 v: fxfspmddwfjvgnvlfht
    6-7 l: lllllsk
    2-5 t: mtnbttfwh
    1-4 m: mmmmm
    6-16 h: hhhkjhmclglhfhhhhlh
    7-9 x: xxxxxxxxxx
    12-17 l: dscpprjwrbflklstll
    6-7 h: hhhhhrvh
    6-8 l: lrlllxlk
    5-6 f: vvqfff
    3-5 p: ppppp
    16-17 p: pppppppppkpppppfcp
    2-7 v: cvvfrvvvvv
    6-8 w: wwwwwpwkw
    4-5 p: ppphm
    7-13 r: rrrrrrrrrrrrkr
    1-10 b: bvdwgbbbbkgbb
    5-6 l: llllrh
    1-13 f: xscfznfffkffgfv
    8-13 t: mqfkltthsbcrt
    3-10 t: dxkwfmtttsgttzdjnrnt
    4-9 h: qjkhqcpshkphnvmjnh
    5-6 j: jjdjjj
    4-7 j: njwlmbjkvr
    12-19 l: lhlllqllsnllbllllll
    12-13 r: rrlrrrrrrrrcz
    1-3 f: fsffffwjfzww
    10-12 w: wwwwwwwwwbwb
    5-7 p: ppppkpzp
    1-2 d: gfdhdpddddd
    18-19 d: dddddddddddddddddpr
    1-5 k: qzkkdkv
    1-4 t: ttttt
    1-3 d: vfdddvhkgw
    11-13 f: ffffffhffffffn
    3-4 c: bccx
    11-16 d: dgxddsldddddddddddld
    1-4 l: ljflqlgnl
    8-9 k: vvvvkkgwbndkkkkv
    8-9 r: rrrrjbrtxwr
    1-4 h: whhfhbh
    3-11 t: kgtvpgxzdlnksxlqrgtl
    3-7 r: rrrrrtrfrrr
    4-6 w: wwwwwwwwwww
    5-15 s: sssslsksssssssnss
    6-7 f: sfzhfcb
    17-19 s: bssssssssssssssssst
    9-15 w: wwbwwwdgdrfcwwbwwlww
    12-15 m: mmzhmmnmmmmmmmm
    7-8 m: mmtmmmkm
    4-7 v: vgdvwvrfvsfjvv
    8-9 t: zvstdtkttt
    2-7 x: cpdtgzxjzxzjcclkfk
    3-14 r: rrrrrrrrrrrrrdrrrrr
    9-10 p: ppfbtpddph
    7-14 b: wsgqgvvbbwfzbw
    7-10 z: zvvrxzwkdz
    2-5 p: pptpp
    5-8 j: fvdclvfbj
    3-7 b: krbswgbkzgb
    1-9 b: fbbbbvbbbbb
    13-14 k: kkkkkkkkkkkkgp
    6-7 g: gggprggjsvt
    13-15 q: qqqqqqqqqhqqqqqrq
    3-4 x: jxkxh
    8-9 m: mmmmmmmmm
    2-4 g: stdggq
    2-3 q: djtqqwfjl
    4-5 s: gcssssh
    3-6 f: fxdffhvfl
    16-17 c: cccccccccccccccckcc
    17-18 l: lllllllllllllqllll
    5-6 r: mvrtrm
    6-10 n: nnmnnvnnbnn
    7-9 z: zzkgzzzzz
    13-15 l: lplllltlllllllllfl
    7-13 c: ccpcbcvkccdcccc
    9-11 k: rkkgbkkkkkkk
    1-7 s: gtgjxsphvmpssm
    3-5 n: gxhxmgnnnh
    4-8 r: kjrrqrrzvdj
    4-10 p: bjpppplpkpxppswp
    7-8 l: llllllwl
    10-12 w: wwwwwcwfwwtwwwdw
    4-6 g: gggjngg
    3-15 g: sggsbgtcvkpjbxj
    4-6 f: flfcffftzzx
    5-7 r: rrrrrrr
    1-6 w: wwwmwmwwwjwwwwgdsw
    3-6 f: ffffffff
    3-7 k: dbxknrkjhvmlkvhzpkt
    14-15 g: gggggggsdggghggrgg
    2-14 f: jkldtmrdqmgqgbkfnm
    3-7 f: vdfffff
    4-10 t: tqctjdkjtsfmwtrprwjg
    1-9 r: rfrqsgcmrrspvr
    8-11 x: xxwsxxxxxmcxmxxzx
    3-5 k: kqkxkfjtmkxzv
    3-5 k: ktkkkkkqkdkk
    2-4 r: sbnrhrfmrknrth
    1-9 b: lbbbbbbbbb
    6-8 s: sskssbqd
    15-18 h: hhhhhhxhhkghhhhhhh
    4-6 r: rxrqvd
    10-13 k: kkkkkkkkkkkkkk
    7-8 h: hhhhhhhhn
    7-8 x: rxwxxprx
    3-4 x: xqxxxbcx
    3-4 v: zvvv
    1-3 g: gggg
    1-4 d: ddddd
    4-7 r: jzvrhjsgtrhvvnrrkrt
    1-3 r: brrdk
    7-8 p: ppvppppg
    13-14 c: dcccccccccccxqckccc
    5-7 z: zzzzzzmz
    3-7 h: phhjkljcktnphbqcn
    17-20 n: vdhznzwkgvrnkzqwnnnp
    4-10 m: mmmxmxfmmsfk
    1-4 c: cccsmmc
    7-20 x: xxmxxxxxxktxxxxzxgxx
    1-8 h: hhmfkhhnzhhhhhh
    1-3 q: sqqsl
    2-5 n: lnxvntmphlwn
    3-4 r: xrprswnhrlglt
    7-9 c: czcqcjcccplck
    13-16 h: thhvhlhhhtbxrlhg
    8-9 r: rrrrrrrdr
    17-18 h: jcklvkhhwkpkshhrtphh
    5-7 q: qqsqqqq
    9-13 h: hhhhbhhhhhhhhh
    8-13 g: ggggggggtgcggsgf
    4-5 d: dddrp
    7-8 n: nnnnnnrj
    10-13 w: wwwnwwwwwwwww
    11-17 q: qqqqqqqqqqwqqqqqlqq
    3-4 v: vvvv
    1-2 t: tttt
    14-15 k: kkkkkkkkkkkkkkk
    12-13 d: ddddfddkddddddj
    3-4 c: vcwvtgc
    4-5 c: ccjwlcc
    2-4 c: cxqnp
    9-19 b: lqbbbbfbsbfbbbbbxbh
    14-17 n: nnnnnnhdnntnnnnnfnn
    5-9 w: wwwwmwzbwtwh
    11-12 w: wwlwwwwwwwww
    4-6 h: hkhhhh
    7-8 x: gmcbzxxxxcxxxklmxxsc
    11-14 c: ccccccccccxccbc
    8-10 d: dvgvgjdjfddm
    1-4 j: zmrnrpjkh
    2-11 n: xblfnnbnrnnbwbmvh
    10-11 b: bbbbhgbbbvxbbb
    3-5 p: hqkpnkppgp
    12-13 p: ppppwppppppkt
    7-8 r: rrwzgrrcrrr
    4-5 z: xvqzxrzzrdnzzhkk
    2-5 f: fffff
    1-9 b: bbqqgnmbbdlzvhf
    12-16 s: nmwzhlpdbssshzgs
    8-15 z: lwzmgdkxjdlzzxj
    13-17 s: mlssswssspssmlsssss
    11-13 n: nnqnxnnnvnjml
    4-16 q: tnmqgbxfwhxlswxqf
    5-6 z: zzzzzz
    2-7 j: qjnjcjj
    13-14 f: fkpqnkfhvfssvhgqfm
    3-4 k: khkkkxk
    5-18 v: wvckvlfsfqgwfrlhwp
    2-4 n: qnnp
    1-13 w: wwwctfkwwwwww
    1-5 c: pcbzjrzvhc
    4-7 v: hgjvvvvv
    5-7 b: bzbbxrqbbbbsbkh
    7-8 p: pppppppl
    17-19 t: ttttttttttttttttttt
    4-10 q: rqpqwqbqqrnq
    2-13 j: djqjjjnjjjjjj
    12-13 j: jjjjjjjxjjjpj
    12-13 r: rrrdrrrrrrrrrr
    3-6 p: jpppvsllwgmmrxfvtdr
    3-9 m: lfvhmmmnhwc
    6-7 q: qqqwqxq
    3-6 p: prxpfz
    1-3 t: jmtkkwvq
    4-8 j: jjjtjjjj
    2-4 c: cnxrdpggjwzxcg
    12-14 r: rrrrrrrrjfrgrr
    2-4 m: msmn
    5-6 s: ssssss
    4-5 x: xxxzsx
    3-4 x: hglb
    4-8 k: kplkkkqskkbkk
    2-7 n: nrnnnnhn
    3-16 t: vltbxlnwvwdslgtvzgs
    8-11 n: pnwnsmlnbntjnknsgnnn
    2-3 r: rsmr
    3-4 x: txxbv
    10-12 f: ffmffrvflfkff
    10-13 t: dtnttttttlkzvnxtt
    3-4 f: fkqvzrljftblfl
    2-5 k: rwrkj
    10-13 k: kkdkkkkdkkkkkxkk
    9-11 t: ftzbbtvttttfbqgttmt
    13-15 h: hchqxzhrxdbfhhh
    3-7 g: gggcgxwgg
    1-3 r: gjrl
    11-14 z: zzzzzwzztzszvzzfzz
    11-13 p: ppppppppppqpv
    2-4 w: wzww
    7-12 k: kkkkkkkkkkkk
    2-3 t: tdllsttgvlrqrwd
    4-9 c: hhzbcqctdkrhlv
    7-9 l: lljzfnhrlxxgdjwlgn
    4-12 f: ffdttffckmsfrfvf
    9-10 t: ttttttttwt
    2-6 n: qnvpcnhqnwldbvbcrp
    7-14 q: qqqqqqqqqqqqqh
    4-12 k: kkkvkkkkkkrkk
    14-17 r: rrrlrrrrrrkrrwrrn
    15-17 p: pppppppppzqppppppg
    6-12 q: wmqcdlqqxxqqrqlqjqqj
    7-8 h: hhhhhhhhh
    8-9 v: vzvhwtvvvxvvvv
    1-8 j: jjjjjjjjj
    1-6 h: hhhhhhhhhhnhhkh
    10-13 f: fxffcldfndffk
    4-5 l: lglnl
    3-5 h: hhhhhhs
    3-4 n: mjnn
    3-4 k: kskk
    4-10 n: dnnvnnnnnnngnxr
    1-6 g: dggggqzgggcgggggg
    13-18 d: ddddddkdjddtcddddwdd
    14-16 d: ddddddddddddddtd
    3-5 w: wwwww
    11-12 x: cxxxxxxxxxrqzxxb
    16-18 v: vvvvvvvvtvvvvvvvvv
    6-14 h: hhhhhsqhhhthfchgbkr
    2-8 f: fffftrsk
    6-16 x: hphmwgflgwtsxzzfcgs
    5-7 f: fffffcfff
    19-20 n: nnnnnnnnnnnnnnnnnnnn
    7-9 l: lllllllll
    3-5 s: ssssss
    6-7 p: pppppfp
    2-9 p: cqjbzfbjcp
    18-19 b: bbtbhwbbbbgbbbbbbnq
    3-5 z: knlmczzc
    6-7 d: dddvddddd
    6-10 b: jhbbzbcdbb
    6-7 n: nnrnnnl
    5-7 p: pklcpkp
    14-15 t: tttttftttttmtthtt
    13-16 z: jzzzzzzzbzqznnzjzz
    3-4 c: cccp
    12-14 t: mbtpttttttttttbtgtt
    4-5 h: hhhwpq
    18-20 n: kbbpsksnvljbclgpzrxb
    1-4 b: dndg
    6-7 c: dcccldrpccm
    12-14 s: ssssqsssshssthss
    6-9 q: gxqqqqknfqqq
    5-7 r: tccrpzlr
    1-13 b: bbvbbbbbbbfbbbcbbbb
    10-11 p: npqwnpppppfpqmswpp
    5-17 f: ffffffffffnffbfftfff
    3-4 p: pctp
    11-14 p: pcpppqpppppppppp
    5-9 s: tssslbssxssss
    10-16 d: dhfdddddgmdbldddpddd
    17-18 z: zzzzzzzzzzzzzzzzvz
    2-3 f: vxfqflf
    2-9 c: wcndfwcjcc
    3-7 d: vhdcdddzdtkvj
    5-9 r: zrvrrrbrbwjr
    11-12 c: cxcncccclcdmccccc
    4-6 l: rldllflllxrlllm
    11-15 z: dpfpzmjjvgdvzdzvgkjz
    13-14 d: dddddddddvddbdds
    1-6 q: bbbqbmz
    11-13 l: sllklmccmlqsk
    3-9 s: qssssssss
    2-12 g: kglgdkgbfkvgl
    1-12 s: pgskhpzcrxms
    1-2 p: sksppgw
    1-10 l: lmgjzlgtwhxzkz
    9-11 w: cjmtjrwtcnw
    1-8 p: pppppppppppppp
    1-4 c: lccbkcc
    1-5 t: ktttttt
    14-16 m: mmmmmvmmmmmmmxmc
    1-6 x: qvshnqtvfvlgx
    5-6 h: ldrvdhw
    6-11 g: hvzggggggggx
    5-9 h: hhhhhhhfhhhhxh
    1-3 g: gggg
    15-16 s: sssssssssssssshh
    8-12 m: kmmfzmpkmmzqmzmzmm
    6-8 d: ddddrbddddddd
    8-9 z: zjppzqzdx
    3-16 k: jlkfkngkfrrzvwxkrd
    4-10 w: jwcbwwdwgwv
    3-7 s: slzsssfqs
    9-11 c: cpccccckccpcfccc
    3-5 h: hhzhhhhhhhh
    3-4 q: qqqqqqqqqq
    2-4 m: bsnmmjjmp
    3-5 x: xnrxx
    2-5 j: jvjjjjjjjjjjjjnp
    16-17 g: wqjzmzlqsxqpjfxmsfn
    6-8 v: vcvvvvvv
    2-5 t: tpttjtwt
    4-6 p: pppppf
    3-12 t: zntdrlztbrqth
    7-14 m: ntmbwzmmwcxwhmvthjmm
    10-11 c: nckcqtrcszc
    6-12 r: rrrrrjrrrrlrrr
    3-11 c: xfcqtzcbdkcbvccnkccc
    1-5 m: vsmmdx
    2-14 q: qqhqspcqqqqszqqqqtq
    4-5 q: qqtqqq
    5-7 p: dppppppmpp
    15-16 f: ffdfffdfffffffkmf
    3-16 w: xqwgfcbsdwvbxhbnj
    1-2 k: kkgvxmk
    3-6 n: rhmbnnqncdtnk
    2-4 g: gvgmgmgg
    4-10 c: cmnckfgnqcqbv
    5-10 q: qqqqqqqqql
    1-2 h: tghh
    6-7 g: wkgqvgz
    2-4 h: xhhl
    3-4 f: ffff
    14-16 q: qqqqhqqccbbqwqvq
    9-10 d: dddddddddd
    10-11 b: xbhbfmjbtblchzp
    12-14 g: gsggfjvgggxgjggbggg
    8-12 f: ffffffffffflfff
    5-8 t: ktljtkttt
    13-14 d: dddvdddddddbjjd
    3-4 d: jkpp
    5-9 d: gvcdpdddg
    4-11 c: cjbddcczcctcc
    15-16 k: kkkkkkkkhkkkkfhfkk
    1-9 b: bpbbbbbbbwbb
    6-7 s: sssswkm
    2-7 d: dvxqddbd
    4-6 s: hkxscsqs
    1-4 m: hmmmmmbm
    15-19 m: lhqbrnvtlfdvwmjfjgh
    7-12 r: rrrrrrvrrrrkr
    9-13 p: npppbpfxmqpsxp
    5-7 j: jjjjpjm
    17-18 x: xhxxxxxxxxxxxxxxxxx
    5-15 d: dqddddzzqddgddwdd
    11-12 g: tggggggggggg
    16-17 t: tttttttttttttttjfh
    2-10 v: kvqvhbvpzvvzgdvvc
    4-5 c: ccccc
    4-5 w: wwgwwb
    14-17 f: ffvfffffpfffhffrff
    14-17 r: rszsbvjwswtvhbnrt
    4-12 n: gbnkxknlcpnznvn
    6-9 b: bbwpbbvzbldbbf
    2-4 p: pphpp
    7-12 p: ppptpzpppppppt
    1-13 k: kkkkkdkqskkdk
    4-8 c: ccjbcczbmcdcc
    9-14 j: bdjjtjjjjjjtjjjvjx
    8-12 j: jjdcjjjcjbsnjbtfjjl
    1-6 p: pvxbzwtgjpbjcm
    15-16 p: pppppppppppppppp
    13-19 t: ttttttttttttfttttttt
    1-8 b: bxbbbbgbbbbbqq
    4-10 w: zlhlwshwrwwgjt
    4-8 x: xxxdxjxx
    1-6 f: fmfjffttvjvfjfc
    4-5 f: jdfkl
    1-3 l: rllnlj
    2-3 f: fffvw
    8-10 j: jjjjjjjjjjjj
    1-4 x: xxxxx
    8-10 s: lhswksssdfshnkl
    1-4 v: kjvqvvb
    5-12 z: zzzlzzzzzzzsfzdzdzz
    8-10 r: rlrrrrrrrrrr
    11-14 j: jjjjjjjjslbjjv
    3-13 v: vvzvvvvvvvvvtv
    2-18 k: kzkkkkkrkkkkknkkkw
    11-12 q: qqqqqwqqqqtbjqn
    10-11 j: jxjjckjjjqjj
    5-8 p: prdqpnppp
    9-11 x: xxxxxcxjxxx
    6-11 r: whfhvqwwwdktscrsndpp
    9-11 n: rnnnbnnkznnn
    4-5 g: gglnf
    4-12 h: hhhnhhvhhphhhh
    3-4 w: wwxwv
    1-3 t: trttt
    6-7 q: qqcqqqqqb
    13-16 d: qwdddkdfddddddrdddd
    3-4 z: hzztz
    4-5 m: mmhms
    3-4 m: mqrnr
    2-5 s: sfjshj
    3-4 k: bktf
    5-6 m: mmtmmtmd
    1-14 q: qgkdqdqtqmjqhq
    3-6 q: pzqqcfhgc
    11-16 p: pxppbpppppgnpppm
    14-15 v: vcvbsdvvjhspflnl
    3-4 s: shqrs
    4-20 d: wdnswjkdfqtwwlwcmlxv
    6-9 j: jnjsbjxjljj
    2-6 x: xmxxkz
    3-6 q: stzqggrmq
    4-5 r: rrrhc
    12-16 h: hhdhmhhhhhhhhhhh
    4-6 g: nglgzg
    15-18 m: mfmtcmmwmmmmmmmmmsm
    2-9 t: ttkkxbtvtqxbjfmjj
    4-6 m: mmmwmm
    1-7 t: tglttttt
    9-11 x: xxxxxxxxxxxx
    2-11 k: khpknqkzkzvbqkl
    2-5 t: ttxtt
    7-9 l: lwldgdnzfq
    2-12 r: mrrkqtlpgkqrxn
    15-16 b: ckgvcvwrspbnxbks
    10-11 q: qqqqqqqqqfg
    13-14 v: vvvvvvvvvvdvvf
    4-16 g: ggwgggglgggpgfggwfk
    3-5 x: sgmffzxcljjqm
    12-13 f: flhfshfnvffnx
    2-8 r: jrtcfddrflfmmhrmn
    1-8 q: vkqkhqqqqqsqqqfc
    11-17 x: xxxxxxxxxxxxxxxxxx
    13-16 k: kskkkkkjnkkkkkxk
    7-8 n: nnknqnnjgnjnwnbrgmt
    1-2 d: dzdd
    6-9 x: xqxxxxxxzx
    4-5 c: xccgzkpvddncxxj
    10-12 d: dddddddddrdm
    2-9 n: fxcbjnwnsppzbh
    7-8 k: kkkkkkkc
    7-10 m: nkdttmmmfd
    7-12 t: tntjgpjtkmnv
    14-15 h: hhhhhhhpvhhhhhswh
    11-12 b: bbxbbbbbvbbbb
    8-10 h: mhhhhhnhhxh
    7-13 f: ffffffpfffffhff
    6-8 g: jgqgsgggs
    5-11 q: jxnzqsqqpqrbzc
    2-6 d: wdfhdd
    11-14 c: hlclcccccccclcxcc
    3-13 r: rrrrrmrsfrrsr
    5-6 t: ttttwt
    4-13 j: jjjjjjjjjjjjjjr
    8-9 z: hfvjznvkx
    3-8 m: tjswpfms
    5-7 m: mmmmgqm
    1-5 g: xgggl
    3-5 v: vvvvvv
    11-17 d: gdnzddfsnzdrwwqflcj
    1-8 g: ggggggggsvqggg
    3-13 h: hzhhhnrhhhhjhhwdhc
    1-10 g: pjgggggpgbgtg
    18-19 x: xxxxxxxxxxxxxxxxxsx
    6-13 j: qpfjjjjjjjfpn
    4-5 w: wnwdjpwww
    10-17 t: tttttttttttttttttttt
    8-12 w: xpmwwtcwmbfw
    6-7 j: wxcjmzdjrfzjrjjj
    9-14 f: gfjfzfkfxfflfpf
    12-13 w: wwrwwwwwwwxgjjw
    4-14 d: rjldjwhcgthnddf
    7-8 v: vxvvvvvv
    2-3 n: gtpnnlz
    10-12 d: dqddwhcddgdtddvmd
    5-11 j: fmnsssknvjjjh
    3-4 c: cqqc
    6-18 q: pczlthbrjhnwdsqtpv
    5-10 c: zvvcwbscwlcblfbc
    3-12 n: wkwpmnnnphlhwtrpn
    3-5 w: zpwww
    7-8 f: ffffffff
    1-6 n: qnbcnnnlnnn
    6-7 m: mqnmmswmmmmk
    3-10 j: fscxjqjxcvdkxnqpj
    1-11 h: hhhhhhnhfhw
    5-9 j: ljjxsjzjjwf
    15-17 s: jsssrsvdssrnjwvsj
    11-14 g: gtglthtxpfljnnqq
    2-5 h: hvspnghwxhgvg
    1-3 f: lffpfnfwf
    10-11 k: hsdbcncfkdv
    7-8 q: qqqqqqqgq
    1-6 b: qrnfbtbmj
    1-15 k: xkmxmkqkbhjbckdnrdwj
    15-16 j: jwjjjjjzhwjjxjjxx
    17-19 b: bbvlwbbbpbbbdbbxbbb
    12-14 t: tttttmsttttflrtt
    13-17 r: mfzhbmghzcsrwldsrmr
    3-10 b: bbxpqmbvbk
    3-5 r: krnfvlfgrr
    4-5 x: zxxxx
    1-4 b: cbbd
    2-4 j: jhjs
    4-5 g: ghgpxfrv
    14-18 m: mmmmmmwmlmmmcmmmtm
    6-8 s: ssncpmsx
    2-4 w: wwvw
    6-12 h: cmvhdvhdkffm
    19-20 h: tzgstbpcltlnvgbvjjvn
    13-19 k: bvvwklzjwkwckwnfkjk
    8-10 d: zdddddcxbsmd
    6-13 d: dddddsddddddbd
    3-12 d: xxddlrcldhdskrsdllt
    3-10 b: tbbrhbbdvbbnf
    8-9 b: bbdbrqbbbbbbchmxh
    1-2 p: vxspp
    14-15 s: bhnskltsxrpmhzd
    2-6 r: rrlfch
    4-6 z: zzzzfz
    1-5 b: ltzpbcrbtxdz
    11-13 t: tttkjtttttbtqt
    2-5 d: dpdkwz
    2-5 g: ggggggggggggggggg
    5-7 d: ddddqkndb
    11-13 v: vvvdkvvvvvvvvh
    16-17 x: dcbkxcxsnxcxszbxj
    8-9 r: rrrrrrshs
    5-6 g: ggwgbt
    2-5 b: sbgqtqcwrkxbqbq
    4-5 s: msnss
    3-13 f: ffbfffffsfffgf
    2-3 p: stpmpbkjsqlk
    3-12 t: xtlrrtkpjsttp
    2-5 c: jccfc
    6-8 f: lxfqfbnrf
    11-12 q: qqqqqqqqqqqzq
    10-11 k: kkkkfkjkkwpkk
    1-12 c: vccccljctcld
    11-14 b: kbbzbbbrbbxdbnbbb
    7-8 p: ppppppcd
    1-5 z: qtqzz
    4-7 r: qhsrdvgrgjcnzwmgm
    1-2 w: tmwqqfc
    6-7 l: lljllftzj
    4-6 p: ncgpppzl
    5-9 w: wmwfwwwww
    8-16 b: vflsbbbnbbbbfbhbvzb
    2-3 h: phhvhkhxhh
    16-18 z: jxsfzzjzqhzzlzzczhvz
    5-7 w: wwgwwww
    3-4 q: qqqq
    6-7 g: gghggcggg"