module AoC2023.Inputs

open System
open Utils

module Day01 =
    let day1p1Example = "1abc2
    pqr3stu8vwx
    a1b2c3d4e5f
    treb7uchet"

    let day1p2example = "two1nine
    eightwothree
    abcone2threexyz
    xtwone3four
    4nineeightseven2
    zoneight234
    7pqrstsixteen"

    let day1p1 = "six1mpffbnbnnlxthree
    4eight3one92
    9nine2xnhvjtjlzj48
    jxrbrt4jmnmlonesznvbjrsn
    nsvkljgpfn77pvfour5j
    fourlkgmnnzncht75
    shqmhnlbjjvskone6two78
    qjgcxccgthree85five
    eight7sbdbgqgcfive3two
    eight878nckqdt3pgzc
    pkdrhksqdhrvhg5
    nine7four7one2
    9fives
    fplzzhthreethree7sqnsmrljgsmnpktfkhzdpqfkone
    hqrcls33sevensevennine
    four4m
    seven331fivekfrqbd
    ninechvkpthreefive8tlmfclr
    8954bxsqntndjmonenx5
    nine7km
    seven588sevenxffivethreehkrczrlm
    3cmjzjmhone
    jfgr2fourtflvttr
    qpplcgvklzztqjkbbnfiveftcqmlrqnd824
    ttsgz9
    9eightthreeonezrninetwo
    pbccq6onefoureightbkvgvtm3
    9tworrchzdzfthreefgksrzjpdq
    chcjdxbninejtwo1nineszf2one
    ronecfcdlsqgfvlxj217
    three4onex1
    8nrhcn3zgsgn3239
    3tczzbrvdm6tphb32
    85threecnqsscqklhsix
    5foureightnine57nshjbgrv
    1fourpcgljhlx5
    v632eightnnjrjl
    zlpfive6xthreeczrknclqdtfiveseven
    6ninekbdmjqrktwo2
    threetwofourlqjnmnine767
    8two5mbs3eightthreethreelvhcgrd
    zntoneightfour1lcbzfhm4msneight7
    7eight5eightone
    8rpbfqb44
    rfninelkclkflsjsrb3
    jzxlngk1
    5zsnxfdt82qmszx
    75threetcvbmhplqmhrcztsghctvsvrhkftwo
    grtwosnjvrpx76
    69two1tdsgbgbprs7
    vrsrmdngjpn2nine
    onesix44vgdtwo
    phtfxkmbfbm61one4pxnvnvld6
    hfsmptwo6dtlnfnmtmrpgmr
    jgrbttcmfkkbrdeight846dzgdjxd3
    jdsfprdmhpvzqbgjdgdvkhmtqzxgm8flhxfive
    qj36gfj
    3twonine
    bszc6bvfkfjbbh
    4sevenfive4one
    fourhxkhxtvtblsevenonekgnpnjqq46ctvmzkqvxdl
    6989hvr4258
    seveneightfivegbzczonerqkdvsfour6
    326sevenoneeightfour
    41five8one3
    zrtnkqtqfive91bxfctxnk
    t226n6xnrdeight5
    one5onetlzbbxchgfhzgx
    five5seven8
    1pnvdbvl2zrjpbkbpthree
    tlctwone39zfdqtnjshzjrqkcdnjnszrdfive
    snklklhpcclkrtkn2eight15three8
    7threeplhsfsevenbgbbnineftvjbnvxpsm
    5dtxxthtphbnc
    six7four
    djsvntknhnqv2qrvnrz
    twosevenbzvfzpbonenine5
    1tq2eightseven3sixvjvnkqq4
    z55
    4mthgcrfbcvphfmglvcjsl8pctb
    6jgptkgcl43bthreetjfxchtxlf5
    5zxgktvdnninenine9
    lhdfivevxrgpkpzrzjlg5mk
    oneseven4seven6njmkvkpjmg
    cblmbxlthtfqfk59three8
    xxcnvsfour298mqqrbcn
    lbvmgdpgbd3hgmpthreefourjbdbfvvv5vfqrd4
    vsxshfhftrgpstxtj94xnxrntxnlcgtdjtqpbmh
    six7fournrmdgzldndnrgrkxlbtdonemjftskhhm4
    1sixtwoseventwofivezbsdvdqncffourkknlsx
    78mqspvdsb2
    teight4skkdlfcsrc38jfjtmfour2
    3pgbppzbmlbsevensix533one
    hzrfpeighthjrf4kqttngxfivefivehzvxnzfk4
    18zldlpktnceight
    six6lvnt6k
    28sixs
    348lmkg9one4
    4ninesnqqzoneltjhsjjbnp2
    rckbvndsjm99six2nine
    eight5vhjvgrrthreetwo6
    2fourseven1oneights
    7threeonethreex
    662dvrszddqqtwoeightsixeight9
    xftcvpmkl2threecdqsix48kgfktcdn8
    3rcgdrjcnmb
    4three5
    two3twotwonine7ljonezh
    17mdbr9ninehhs3
    nchgkdvbm8onebhdtmgdgkqjfour
    1eightpqbslptjfgninenine72
    1ghpjmc4q
    245seventgftbfkbnztwoone
    94gxjjlptflxsvsrxxone
    seven3three
    7foureight
    mxgc6
    sixthree6rrdntczlrrnsnine
    9three4nd1eightseven
    ndeightwosnlvkv8jdllrtwo741
    threefour6bkscthreeeight
    hffoneight96vqkbsgpzvn3sixtxh4ckjlm3
    vc6tnine5mfplhklmv
    zoneight35ninefour1q5ssmjtf
    rkblg8tzdjhrsdxbcx
    kgvqtxzjr56psfour9
    6dtbh67five
    qjx4two2ls
    hfstd58three65twosbxll
    g2twosixvlvtt
    sevensix4nineonetvfcctgnj
    tkjbktckztwozzstwo7jgxbxxrkzx
    8gftwosjkhqxvfpqrsrseven
    sevenkphl9eight91onesxjvtfdccd
    lcrvslcc6bhzlcmz
    bbxdjdfprnjtxhsevendzsbczc6one
    one5m29
    h3one
    sixtjdgzvfqpjvdthree421x7
    eightfiveeight8sbmspqltvsxsix
    four8two
    5sixfour94961
    9two6onenjfsnqnmfc
    fivethree8six3l
    1twokzqnbclbqgtbeightrtwo
    7csgktwooneone
    75nine8two
    fourrj5tfdrlgdzrfptxvnine
    four4seven5eight
    6onesixtpsgqgk5seven
    qpznmcmfgpfqmzvkthdseven93threersxsktrkk99
    587nine6eightseventhreeqmjv
    zfssixvkhtlcmltwo7
    8bqvgfnzg
    6l2eighttjtgrj1knrtjqrpjd
    lmjbs6ninethreeeight58
    1ktxhfzkgrfmtthree
    xtmfsxsdfgfivethreefour9fnjcmbdz
    vlhlhzsevenonelhql285xccp
    3172bndlm4sevenpnz
    6sbzqfftqnfourhktmxxqkthreepzkjvfxxfour
    sevenfoursix544nineqr
    9eightsevensevenqrxjzmmfjnd
    ceightwogntfttkkkdpsq3
    gpmtpbchjdpgmkone8sixmhm53
    ndfz9twoonelprmtwoslvvp3
    njrtr14sevenninevmnbone
    1q
    seven1eight
    svstnvxdbmseven9pbfrsgvlhd398
    3ninefivelbcxcfcc
    9njgmxpeightpqgj
    three6636bbqrtxprjb4onetkkgxxmtv
    7ssrrsfourfournine
    4one1eightzgcpkgbpgmsevenninetwonetk
    threelpmgdpmmsevenxkphrddr5two9
    plpzz4
    91fiveg
    fournnjzsnrqzbdggldr9
    llnsix5sevenfive45threeone
    xxnftztcbzrptthreervfiveseven9sevenlnxhzvk
    glceightwo4eightnineeight9fpbp
    six6eightfour1fjlmmqlqszvkbspshcvnjlxfvmm
    6sevenfourmnv1qcf2khfjclcsx
    fivebsvvnhgcp6jdqrcfreightwohfh
    9eight5onerjvcdct5
    jb81onefournine35tftlzn
    59sevenpcfninevtrrrhmeight
    hkphm7five
    8ttb
    eight9five85pxv
    72threepsixgrvfourgbbgbgprtxmhlz
    1pgdjtmkntbjfckgq
    9brqcqvqgzgpgtvbtktxkxjnine4
    26fourtwo8
    six3tncnc6pbjkbkgninenssjbgqdpeight
    sixrjtfbdlrv5rdmpbqfxfxrccs
    kmbcgt81seven9jsnvdtwo1
    9sixseven49hzxlf
    jmcssix7onesix
    pzttczmzhgtgtvvlhpkv5jnjqnxkhceightfivepnfn
    1955xv
    sixthree247nine1
    jfdgxhkfour1eight1six2
    threefrdlbmnqrreight4psfonegggjj
    391eightfour54nine
    95five6
    dqvseven8five
    3onetwo1fivexppqsltgtwosfb4
    6fivetwo
    5eight4j
    7l
    7khdvfks5threesix2
    46fivethreezfszfkxctworjgtwoghrtpz
    threetwokjdljphg5onefoursevensevenjnc
    rddxs722cg
    pkpsgblkvsevennstsqvh3twofivekkhzzhqxjjsbvvvvnine
    fivethree77one
    63twonine727
    sglzpbvhccdvdnzdsixthreem6fivesix
    ldmtseven7nkhsqkklmzltxvmkrq1
    59kfncssdeight6three7
    zhltwonejbmfvmsix43
    73twoninesevensix3
    five4three5eightsixgvfour
    twovsrjkxtjj5gmbvfiveqmqscfqpsix
    sixzdbfgtzk8zhthreecdvvqjbvrcphvhqmlxmfive
    nrppflfnine7nd9tfseven
    3nrclsix
    dveightfive1
    3qrdtsfmktwo
    ppeightwo4one3
    159pfsbninezgbpvqggfbfxcqzb9
    lrhzqtjrdxrfpbskrseven5qqrnsh
    nine51twothree12
    2six5fivehs
    45sixtwothreeone45
    kjkfggmzqxrjl4
    four5five
    srtgklg3fjb92seven56mrk
    eightzlmsmnthreetwofour324
    fivefiveninepvfsxponextzdmft4
    vneightwonine7ntgxbzfouronetwofzzgkkhtx3nine
    ndcvzhxbrqmfjcjpzffourfive4gzkxzzlsqn1fjdb
    2799ph
    6nine77twoznzbjnjhkqljmsmnj
    bkzttcjdmpdclpzmpxj67tfour
    6btjcjxsevenfcgbjjsxhmlklvzv
    four9vpfpknine
    onesrjxsfncglvkzs5tpr
    qgf782lqzvqztbqjqrqdnfpkthree
    seven8f3four
    sevenpkksntfdlqxvqjfgfourztpbglbhmhlfftmxtp54
    6fourseven4eight
    9lfcjnfournine
    four8fiveseven7threecz
    rfnveight9threetwo5three
    tml98ckph
    z4krthreeeightfour3
    six3fhsixxdpmszsbeighthlgd4
    9hbnqkhsndvsevencrl1six5hzg8
    6two5three5
    qplckfdsgd2fivefourfivefsix
    ninebfour26fivetwonem
    hmbkjkdtnfnzs6
    325lpxntm
    lxtsevenfqpc7jvvtbppczsrmfour
    threepfpnbkvq59fgmsrglvcfivenhb
    5cmq8vxdn2nine
    zpzvknntdf1threefour2zdh
    five399kgztnine
    nmddfssix3sevendrbt
    seven7fivebr5xc
    177two
    3four38six6
    eight9four
    49llmpmzkfgsevenrrbdzk4
    four23ceightxxthtplmk
    qmjjvkfd34qkkd3
    foursevenrgjxsvlkz7173kr
    three82fivermfnqgcfourtbtnpjfnk
    744mpdkhr87
    75qfzxshzphsnineone8
    two6five
    fourbhgndsgmceight3
    2one186
    833xjbcqdgmeightfive
    pfgt93bkzrzbthnssevenczvkfklkbpgnjt
    dlsix8seven5
    4two4
    qtblgfgms6lsctgslddgpnx1cxrmbnjconeslscbqvljpfive
    mllxhpd5
    kfvjhcz9seven16
    eight36
    633793
    phqeightwomd27eightqkcltdfourx
    2fiveonednjb6ninepznvnhrbvdsdnine
    8eightfhjdzzhmct74three
    vxps976
    threethreebbninefive9
    6xdttgthree9rpg
    fivedfbkffgldktbt6fiveqlxcznqxlgltc9
    4ltnlkdmthree7gcbqnskeightseven
    onefournsjgbcn34fouronexjxd
    169326srhszxcrn1
    5meight6dfive
    kztjjnknine2eight87nineskqjpvn6
    seven3four96
    8four5kkgmppkt
    52six8fourvtdrcj7five
    9tgbcxcvggv4ninettxjrjv
    ninepdmghhq5sixtwo
    fivexvfdone14
    foursevenfourfqjqthreefour4qcvqglr
    four9sixtwo48
    pzvrgmbvngtvcmmgthreepvb7sevenfvhxchplsfsdcltwo
    gkrnmzzrd3
    nine2qzgltqninelrnlrjzn923kkpmpm
    7tts7qmbthree4539
    sevenone9ghdb8
    jvcc18fourninetwoqvkg7three
    four4onenine
    19vbsdkslnn6sevenktkqmcp4
    n6
    7psthfqcfd
    99nineeight861
    1four3eightbkfnrdcqdqdmkgfzbbn6
    27nlcslnseven5hdvsix8
    9nbzzjjsvtwoxg3seven3nine
    7sixnhldjcjfsgvpxrsnxtcblpgvcvjrmkhzx
    2726nsdtb1
    2five3six5three3mhnclq
    sevenfivetwo1fivekpxrpjkgktwo
    7one4tnkqfvqlmjrzlqflnrsf
    nvlkqzjt2nineseven28
    ltqschggjgrrxbtfz3onesevencpzbffbvzhpgzmlmxxbqjrtxc
    518sixeightwop
    cctwonetfmvjx78
    2jvrvcsevenlglmgblbfive
    7seven1fivevlbhbsk
    48one4cn6
    3one6
    nine4jrlbhnpsixvkrcqvzsjj7
    5twochgfgdsevennbmzmxfcrqfeight7qqkhqlrpdf
    71mxlhzstppmffour1vrtd
    82xdqfourkgbmzninefive9
    ddcxpmzfljmfrqz3
    five5kcdcxpl3four6
    4lsfzhbc8
    ninec5jnccxhzdtmtcdjhdrvktgtjjlbnsn
    29mqjflc
    9nine3
    79sevencnj44x3
    4fivenine4three
    1lv
    fourfour8
    78xrszkgvptd
    htmhxvsmppgxthreethreeeighttwo9
    nntjqhnprfdknfs43ngmk4five3
    gqncsix2rxxkjdschstwodknkninefivebfgq
    eighteightqg777579
    5ftkjlz7
    qfqsix7
    three79kk5vnd4gvvpjb
    dsbxmgs2frm7eight
    2kvlnkrbxxm2seventwosix11
    nvneightwo8
    5seveneightxvspone
    fiveqhls26498
    1snrdfgkc
    425jqfpteighttwofive
    8rsxmqsftrccbfour
    7lb82vxzfk4sevenfive5
    sevenhstzcvvtnjninehhtlnkrldx8pjsxkrlcjdfivezkqdfour
    8six3dmr6shcm
    6573fjkfndqrksixnine8six
    twombmxvbcnine1mzhltonefdlp9
    sevenqzvbpsslz5rone
    8fdllsixonetglrngmdnvbsvjgflzonetwoseven
    8nine6eighthlkj2
    5rpx52
    xseven69bbj1
    qrthree8hkgcsqlrcf5
    jhfrvzb5thgmbtcg
    nntfour97vgknr
    ltwone4hsrctbkfsz9jsfbhkm1seven
    mgxnbgst84sevenfivetwo
    gzdrfhqfcfdhxthree6sxxnmntpkz
    3ninepkzhfq1
    fouroneone7
    8threetwo56bpjjps
    4dvnttthkpgpdmcldvfour8two
    2k
    twomvx81fournbts47kkzggffpp
    19seven
    xcbhbdlrdfthreejxjsngllfkfive6pll
    52nine8xffndctr1one
    dvqh7eightdnlmntwofour8
    5rfsvhh21vmcxrftwo1
    rxfddhhxzlnlfvrk3eightzzhpthree
    92twofhzeight
    djxldch5rxkpzxtcn2smb
    2nineninetmhkstmpcprcj5
    brtronetwothree65
    4four6one
    7npgvjpr
    sxvvbhvqcrftwo4fourrtjdnmk6
    gv3twofoureight3qlhtjbzbqt9six
    rlbrgkrsz818six3
    fourcnsbr3rnzcggxqblhqjonesevensevensix
    threenine5eightbx
    klqrlnvgseven22vdrlvbseven
    jzcnxdonenineseven4fivefourfour
    4dxjsvlcvslqtmqpcfbbkqhfournine3
    3vtjzclgklnszrv2sixddkcqgbxptrdhnlntrnr
    one388qzqhmpzqlqtwo5four
    sixnine441sgd9blsvbpnhpsds
    732twothree
    sevenqrvrvttnld9fqvvpgpnine39
    threetwofour28
    twofiveksvbnzfmzcbvqrnhsntstbrhf3
    fjgcdtfn3
    xgccx584six
    2xsevensixtwo4six
    xpheightnzdjgkrdmrjcnfprzvnine6cbtmsseven
    nine1fivebgqtvsc8
    dznrlhtfivethree43
    sixthreerlmtvs7kkvtcx42rgpnljbsp
    4frckxvvrd
    eight4ldhkggpg
    z57sevenxpfgntjnphcntj3bv
    nthvgtxcck39vkpf7
    64vzmzlvgeightonefive1tlvfggflj
    fivejrjqzsfxgpdfbvcf58three1two
    nine5five
    ssphtp472xjfvlvzdl9oneightg
    nine5xltblt9six
    six28eightts5cckgvtnzmdgftxnine
    tvhxmfeight7
    zdnkjgcs43two9
    q35bvblmmqhmnine5zeightwoj
    gfkpfbn4
    fivefiveone8
    xnsddskzsb6xmfvkhbb54
    nhsjx51ckpbntz
    7kzxsgtnk5sixjlzlcsfqsxkxmvgnvthree6seven
    fiveseven37
    fourfqxkjct554
    rsseven8zdz8xrxpnxv9rkqcnjcpgt1
    jsixeightsevenrjpcqmdz5threeqfqgfqv
    1threesix76tv4twonetgv
    twonzhmrjlgvtvcj6
    kxnpphq94three
    zone4
    5kp4eight87
    93eight9seven
    9zpz7zqxb1ssgkvtbzhrv8
    sixvtdvvxmz2qcvrsnxcmtcszsnrnq84one
    ninerggcxmlfqcpjhpjjtlvs5nine1seventtcmvrfr
    five24
    vpkf7onetwofive
    8twosevensix1
    53fivethreetgzcmzsm3fivefive
    twokpjnmsc77
    twofive53mfjjxq2
    5four6fb4four3twocn
    fivemvbgtsix55nine
    five65rntfvpxpppkznlfour8
    nine42cjtwo
    eighttwothree9247twoeightwoxsq
    sixlktcgr17six
    kpbtwo57fmhdmzmqbt
    442dkpxgnine6qbzf
    8fourkmzjzltwo
    ztgsrqkone78
    dxzsnnsnj1mkctsix4qqbxscdfm9xvngln
    four993kql7eightfour7
    pdrtdxmpmm39qkppdjlttdn
    ptpvc9mvlhfjkrthree9onesevenfourqbvzhdmc
    dddkfcxrkfkphnhmjbrvmzqeightfourtwopzrmh8
    38tt7psevenvgssvhfbzrhllbh
    nine7fournine6sixgfcrrmnppj
    fivezdmtj1
    ninesix5eight
    6eight6two2threetwoneg
    ninenineseven4
    5tpcvlsqqgv3fb8fsbtfivexbzdx
    sixzxfxjmtm24one9422
    sqbqtjgdr3eightnbjhzmbt
    fiveone2nine9
    8three4c3fdxnm81
    seventwovnine4eightmlzhtkfour4
    mfkf42
    7threetwosix5
    1qqgb74eight
    ttrrsrsrqjtwo2sevenseven8twofour
    onefivefour14hzdvdvvbrz9eight
    bkqplctgnine28bptqbpfhgs
    1zlhfourlqtljgxztjtseven
    64two
    gkfsvbgsone8three1ch
    mmjqbmrk494qfbhgl9tdhsldsjvjgbq
    kdnldkpfqlqsfivelndmxtbdfc5
    9lgtxsc
    xzrjpshsslqvbcthreetsixlql3khxbn
    three99tcg8nineone
    4jfive8thdhvbl8dkr
    619fivecthgp8bcfszxrm
    onetjjsmm8dtpkm
    two62zlkgsevenhqdp3
    8zfgtfnxvjjxgptxkpkdb1gkndcsbgvzxgqg1oneightq
    7vnkhnssixkhrklsdbb96
    3sixsix454four
    htfxkcvbcbdpmlr42
    5dspnxhkrvtmthreeseven68xnxbcb
    fourxmjlnngjv4dcqninebbfprffgzs
    three523eight
    fnxfctsix1
    6jx6cqbjqmzmz596nine
    1three2eight1five
    8twoprjjfsthreepqxmhc838
    vlpdsntkqpxqdjzggtjfk8five8dthree
    four8nineptrbrtlninecdseven1
    tfvbjctfive49
    four9fivecsqfs
    fivefiveggrbf8vcdftdpzhc68fiveggr
    sfvhspbgtj2
    seven1two7bvdsq4seven4fmbfs
    1hrcsbmcvcthree11
    98two
    rnvmdvhrthree6
    3ksnfzfkrlx86dqjlftjdmtjrbfrsgf
    twolsxrkone428
    four6eightwokqz
    five2sixnine1fourhdhms
    six26
    5seventhreedjsgshhtmlmpjk
    14shpdfxxxzrfseveneightf
    vprv9two6
    nine3xqkpcdqfourfive
    dtjsf923fourjdjzzsmxjh
    2fivexdvlgrngjbrqdvzx
    6f
    five191htbfdg2eight
    qmfblcvxfzph8two
    ppdkvczsthreexhvfslpncbpqrqkz3k
    896
    nrzpqk3fivesldclpcbfmdtbbhpxonethreeeightwor
    7cnn871
    sevenfgnc58lllvzfmnfqsshvjhqpgvx
    6hfrhvklvpp
    onekcrcpsjtsndskmbtvmcd1seven
    6twoeight5vmdgvhhjsqfourjkns6
    zlgseven3sevenbfgzgpbmhlbtx6fqpb
    7pone828
    vc7cjzjc94
    pmmzhthree36twofour4
    q5onesqltxfourkxx8
    fivedsvbdtqkrzssix2six
    sevenone2four4pmn
    fivesseven47lndonesevenvfdvkp
    vfxzlzvt7
    hcqf179
    6eight3
    hmftwone37dzbmone
    qonehzfj4
    eightonesix7
    6pfournine
    onefivehdt88five
    three2eighttwosix971
    xxtffpnkd6mxsjmhbgp2four
    foursixmxrsmvhrx97
    dqkc9njlxh
    nine2fivexjvsmthree
    2597frctprbrsix7nbcnktxpdz
    6vvtlzd29ftgmjbjjpscbvkcmfzpcj
    bpmnr2kpdsxseven
    twofoursix7seveneight
    trcfdlp5qnxmdeightqmzd
    seventwo7blpfqnsqjrbgzxvzxfourdtstcrv
    z54five
    llrjhdptlrzzjngrqvksbrmhttwoqfmlntj8
    fhthpcrrthreethree7fourfour2
    sixfzgnfour81threepdpsix
    3ddxksjkcxltxgr5one7eight
    6tskvfz
    1twobsdnmmvzz4three
    15ljtrqkh7xmqbmbn
    22threenine2fkpzshztdhmdcxdz2
    9seven12six
    9ninethreesbqcjqvx
    133bphdqcsdlbgmhjqkhdnvtgvfive
    1ninezkvjfmmttvldxq
    fourxqjxmjvb7
    foureightthree4
    6one8
    two2twothreervhzqnl
    3ninesixsixtwo7sixeightone
    nineninenine6ps3fourmhkspqqz
    bklcqxggmp9ktzvmlvmmeight18
    1onesix2eightnd89szcklv
    pttqvhsdxp28htkfttpnfourseven
    5eight9xjgzrxqskttjhcb8ghlxjhfourht
    eight2l714
    9xcqnbfive6fivethree32
    zgmbvjtwoone4
    rvxfrdhqq4sbsnlrslh
    ninethree9two
    6sevenmdvsdqxt3vnzdgninejkdjmzngckfcdh9
    jskmdkhhn443onefjdrhqn
    2cnkvbd
    seven5rh6eightmcpkvcdrcfivexntt
    eight1gqtnkdmvsglvkone87
    four8six
    67ninecvqcpxpfqphx
    3schxdptgtgfjdbsffxg8xmhxvmrnvfive
    mlxqgftbrkvgkczkone65two7
    jzrttfghtqonezjpbxds3fiveninevppqqqc
    4sevenjqbnpjlhj
    4573one
    eightclqsjjjss6
    one5sr3klmrccnrhd8
    jczvxzbvvctxdzmcg3sixtwotfvkcl9jqffdh
    cjtslmnine8six
    rrzktthree3two6eight
    sgeightone23five6ninekstjcksnst
    6nhkdjm2fouronehrnd73
    two56six
    6six2xmczcgbpj3
    fivevdhnpjxcgrmc963
    6746rrplshznckgxrksgczqthree55
    onehxkrhhkczt2pxsfvlgthree
    9threelgbzzjxzfsjrmvnvcsqffour
    nine7gfivefoureightsix1
    3seventwoseventcbsixllmhlmjbtqtfpfrjqbghd
    1eightzdskcnhbm
    rlccvmpnzfoursix9
    nine2xbmfourfourzncxtjgkn1
    1264cfmm
    smntmjr53sevenmjghvnvhgrhxq6
    7szrqhlmjkfqspnvseven
    29krc
    hpj37eightgfzsl95gdcdbtsxqh
    xcv736
    eight3fourhtb43
    threethree967rlpk4nine
    seven2931nhxpkppdv445
    3eight5hvlxjspmsdfivedrfsmvzr
    zgvvcpthree83twofcvqnine
    seventwo2bgxcnbmzone
    threesix5tfthree862
    8brzvkxz
    713srdjqdnbbrvxhn4
    3t7fourtwoeightmjqqjbknp8
    btltwonefour2rjmfmlsbmdfp
    8sixthree1
    fourthree3sixhphctrfiveonesix
    eight11fivesix
    ppltwonepcmjdmtc2sixjpqnvpczbmtplqcsz
    pfn2
    pfvqrm54mhvzmqmgtwoneckj
    rpsevendfv2onethree
    46hrhrkkpp74threesix
    fsrr8
    7twofourfourcpcbfourfivenine
    onethreefive71rfhmtlzb72hzhl
    t71three6hdrnfour
    llmdhfeight9
    lgzxltwo3twoktxdltzqv
    sixhlmbbzlqflq4mlsevenmsdsfqsqvnine
    3lpsltdnine
    three1sixfour2
    3sixgcdf1
    four21
    84foursixclbmxpctn1bjsl
    brsxfkdp4xzvggqbqtxsx6threethree
    vccz3threetwoone59
    sixjmpdtc1
    tjshpfbvmllqfiveeightfzvdjsczqxg2
    twolvzsmjjseven8
    2vnbbrtzts9mxzsllltone99jvsxkc6
    nine3qninesix
    8qdthreetch
    two1ktnbjxqsjsixonepljgnmrgnb
    one2one81tsvpvj85spn
    31
    one2ninelzpone4
    twofourthreejgdbthree7three5two
    2316fslp5
    threettcdspbsix3three2mpkxzspltr
    5sevenblffmddx5xmqcbdrxvhmqtwo
    1threethreejxplkj
    plqqpf3fhsgjclhg4sr
    fourone1fivefive1fourpdkjszpcsd
    8lhthrsptzbgzllzkrhpqdbkfivedrrtk
    1ninefive2threevbflj
    4sixfiveeighttwo3threefive
    qvcxfrjgm6threetwoeighttwoneg
    2bhfpjnxbttwottrvdmpssgjjvqjhkdskmxjqone
    18czsfmq
    58dlqninerqt4pdjzktspssixlgdxrddt
    3sevenrcsqtmfrhk694
    93ninevttdgh
    2dxsmtnnqseventwo
    onenrdfhqg3six
    jfjeightwobstfsln8dvvdmgdhgxx1one7nine
    fndrpmkpbtqgk7six8nhfpnv4hfvcjnjh
    3hxtvzbhqbhkrtqmphfivej2
    seven818
    czgrscnine3
    3pltt62three5seven
    2mvmpqrgdm5
    six52three1sixthreeeight9
    onecbshrmsrpjlkkrrnine7mvx
    five34
    sixjlfsixone9nnzhkvldeightfourpbf
    four47nine7
    three462fivefour6
    nsixonefivefive6twochreight
    9twofourppg9three
    lcpggjmppmnkktfvszbl7qmxqrseven
    ztwotwothreekdftqtqmpeightznhnine7
    bptgpcxxknsgxbznnxzhnzx59rvsj
    8ntnpqdlkfctckk7qbcfiveone
    1cvhlrj5five22vrpphp1
    m9bbpngzzrsix
    hbflvlnzln9xhfdsfqqxvnzdpzeight
    22sixfive1fourbpncphnnkrlzxz
    three8fivecnvgtnpmfkzggttcjonerxq
    qrfksfzjvseven6xqsmdr3two3svdjjb
    48xxtqpnxthmjbzldrv
    gblqlbb9rzfnr
    onehc78sixsevenonepfchbfmgzp
    lptwonefiveb1131
    lzcbfourh9qvtsggsthreejnjjnmtf
    1shljseven
    1gdghnzhqlseveneightsixsevenmblqvjpxd8twonejm
    mzfgmtndztwo3xlvxdcsseven
    59hvnjvjgxxtljdsgrjjpzcmxgninenineone
    fivetwothreemdjcsevenkcljqpktwo9
    toneightonelb4threetmldjmvjlfrnmkeightctjxdqhrcjczcr
    six4jnlftktspjthree23seven1xfbrkh
    fourtwo7fourqzmcrseven4
    clrgvbgcbb1twonekgr
    9one9hbdmnzldksix
    three161vfrdvbh7seventwo
    28rxckppjhxn139sevensixmd
    sevenfive5twobdxhzseventlf
    xm48781four
    tdsqpmcfdjvqtzt56nzlbdrm
    fglpgdqonemsdljnq1
    5foursvgbnthn
    eight14dcvcvgrlkm
    nine8kxjvjskbvcdmmbsgcxpheighttwofour
    knsplfsix6cqkhsevenlkknhdnvl3
    eight47fnhssqvdt9vzkr8
    dcjx1rzxfk3seven1twovzcsddtckg8
    1onecqxcszfqrcvm5lvpb42four
    sqclpndjgf7
    kbxbhrgxsfbljnlbd1lflxpcm298
    nine1one
    nineseven1one
    9stlxptznqgcbjvdgt5ninesevenlkxsix
    xlhl2nine5
    jqpx1gbxrtdv3
    981six
    f795bkkjmmddhvm
    2ninexblcgmhxxceightwop
    twoxkmb9fvmvljzjd
    3pgdsc2onestzh
    zpmmdf912three
    9fivedvn
    five23five3
    sixonexxgxdqjsfmeighteight2three
    4eightxbss4twotwo
    six8mcbl5shdgpglbdrn
    4sixthree7sevensevennine
    7pknqttzlxfive4
    nineeighttwotwodbdjonethree3hp
    3972oneeight7
    tbsqftsbnhbgljmjmk12pmpfplhqb8x
    sevenfivesdrsevenfourfive5qfvqsxeight
    lxvfv366one3tvlcbfhone
    4vqlcfnineghvkfm
    qdhfqqeightone3595one8eightwov
    rfsdbjkk48xxeight
    3fiverbspbvtpg3ninempxcrkfour
    37ninehnpdmdqcgvjfour9
    164two
    twoonetwoknlffnine4two
    eightthree9zhtntdsf5mfsklckp
    zrznzfxpmqfive4ppjkjninetwo6seven
    9tnztckdmqdmcthreejgxrlhmninermztwo
    qoneightsixfoureighttwo2kjlpsf
    fournine315fiveone3
    hcrmlngq73eight39four5
    kqtmfsdfxhvhnsxmmbtbk7sixsixfive1xnb
    three7eightnine
    sixfivetwoeight14eighttszxffvhmrn
    7ctxfoursjqnghg5sixtwo
    one4b8
    123five8six
    two6seven7dplzhncqx
    four7ninedqfplv7threenineseven
    sixdqjcllsgj28sixsbgcxbdkeightb
    415kmxtvpdthree
    ninectmc3two
    fivefiveseven2two4
    mvsg44fourrxsmdcxpbzslzdhbgqlxeight5
    bxtwoneone7bxxmeight7rp19
    sv2chpqrztht8eightfour8nine4
    dxlgdfqvkdgvdxlcxkht9
    sixeight6ffivethreesix
    qjmprhcxdgvrrqdmlzbbpkns8nine
    ninedltfrzpq8
    8rjqseven
    273phmpjmf26clqgmckqrh
    6dqbgzgqbgrhqqmmnjpmvsdbjxkgs
    fvpvclz4msmtzdffplbhkpt311ss
    zrvhlnhfxnzthree7
    oneonezclqbxxd6ninesixthreefour2
    q7vrltqqtkd9zmxdtcsrtwo
    vpxl9zldgphfjk3hz4
    clpllv8cmpgdvbfmp
    7xxdlnfmseven475one
    6cfgvvzbk863sixzlvv
    25vxrseven
    5eight4qbztpc3hbzvvpxscgcn5
    eight7bqqtbdqmnine16rh5
    threempjzsmbtj2
    nineseven76kdbff8
    93twoeightwoff
    6threefiveone9
    nmmzcpgnjnpzr6threeptconeonetwo
    fivethreetwozmrcg5six6
    onesevengrcvnhdlfive5seven
    fourfourvpm2lsixfive
    2four2three
    seven88
    mcxsggtwo1eight5threezqvk21
    tjfmcvsbvcqch774two5
    two51vgfzfszrrcqnggr
    threemqkxvthree2
    2jftwothreeseven68
    rhjszm7brmnclrhxsrck
    drhxztpvfp9eightxxsdsphrsix13
    6pldmbdxhgrqxd7
    sixxlstqkx9bltfnktdrkeight
    vzhpgmtmk5five885jvdxkvmb
    fivetnldpkbnqrptone94four
    3zqtwo8
    zshvvcjtvbmjpqgljfivebrcsl2six
    ninecv2dlhgzteight2
    dhlfdgbgheightqdzk1two5zbggf
    eight2t7
    4nqbjfxtklzfour3
    8qrdzcphsvndbszdnbcndfszrhmvzcszzsgshml2zgbgjx
    nineqttcd4five4gfjlgktkdlrmctv7
    nine4xfgmfvgg
    3mtmhkcsixbbpvzgnklmdxvkrninezlnrds
    txsmflhl7qqlcbn47
    six4kvvfour88cfmzds
    3sgfourbphmcvxfqqzgfthgnhf6
    3fqgdnqtwoeightlzplmjlptzkfour
    9fivenj9sixgtmghntstjp
    794jljzxngthreeknjkv9
    513five
    ssix8three1twofivegk
    ninethreeeight4vfqbgbxf5
    sgxldeight9
    six189
    vdcsbmmcvbfqtgqgfoureight6gdsznd6
    p6
    58ckjgkrstcgtfm3seven
    367
    shlnlp9sixvvbctrkqd75fournine
    mqltnzcrqmljgmseven3bqqhhjncnmtwotklrtxgbcn
    8fdgshseveneightthree1fourkp
    8sevendsmpshkthreetwoztwo1qtpdxr
    mfive97xs
    xdfourmvtxt3twofivenhtznksix
    one56ncxzxdfv
    sevenklqngxp27jmjpbdsskz
    43zlpqsjz51twogdmszvl7
    4v35q
    mtwo98xxhxqshv1
    fivethreelcnhjcsr4tnbg
    65r
    mhfxxgdbthreesix3rdpfksvpxqbjssqmksxbkqxk1
    mnthlsxffourfour6threezcqeightwosk
    qjgr1
    fourone7eightqhsrxpjxftwo3
    gd7qlsjvps
    one5rsevenonenine
    eight95kzddddkmjfbhjtmgpccxqqfbszstxqlplmtbpthree
    sixbddthree58
    xfoneight8sevenone3
    fqdhrvone92nine
    ffhtwonesmcmlddsix15nineqgkgbgvnj
    pdnmmlxzk3814
    trsmkshtfeightnine5
    hjqdjh65twoqrqcxseven97
    66twoxdlmlqrhk7three
    m841
    lk4
    591vqcqrdzsddl6
    jgvmbdflph5frnxkkdplseven
    fivebmjmlcs75seveneight
    fivefour9bcslbnr9fourtwotnzqshcvoneightnz
    sevenxbqngpxmpqnxbdmxhsdkkdbb2
    vxqeightwokkdsdcgq7fgjlbcnhlzgjxtcntx
    7five4nine7twocbjsctoneeight
    fourfour5mqdqfbnineqvksvbtnfive
    67four4qrbddqcthree
    28vxtbdcvqxrlrqm
    2nine4mltwospmqm6three
    fmzgbtkbckmtk15seventwoone
    5bjnc
    two9one5eighttsptkjflxfvzvp
    qcnlfjfpdgh8onestone
    6kjbqqczjktsixk1p4gzjrcvc
    crdhznlrrc8qmrgpvlrd3573
    five55twofiveqhxmlnlscs6
    onegrcxflkqb6fourtwochltwokpnxtxmzfive
    five6qcbjmffzktsmhzzdtnqkc
    919eight
    pboneightseven9rppzrmdrcfive75three
    gdjtsgbjzkgxbnzk9qpgblmqsmssvqzcpmffneight
    vbfrxninetwofive123
    foureightseven9two
    53931sevenlcsxmlzthreelnsjtcm
    dphhkqnptwot2sk4
    94fourpvfrtgrms
    four2gxnc8x
    nine9mkfljgc
    eightmxj83sfr1
    9qlldctxqttonejtsxhdzjf2nrpmvpgeightnine
    1threebjgpnsmltszbjmbvpctvljjzvbjb
    cgszmdlcssix56jphvdsbh5
    ljjlmxgtkrqpldbllmjsctfv1sevendgnx477
    94mlgfrfive3rlbv4nine
    12tr3kcbtjxfxrsevendjrzgfqb7
    7tlsvjfive3
    fourbgksix9lnine636
    rpvftxcnone2
    bjgtmdrgrrrpxndlmvmgl829428
    hfjjkjg1seveneightflkhhmmd
    3one273
    nkkxzlrkgfonesevenfour7twompjpqdsvpp
    qctwofive7flqqkmsqplbb7eight4
    9bkshzspgz19vhmsseven
    17eightthree4bq
    1three3
    rdrxmvddjrdvmczg8fourxgskh4fourddcm
    eight85nineone6onehxfcqhdbb7
    5seven8threemvjsmmgmone2
    7five7gfnnfbs4fourfive
    47vkfndgnlv16four
    1mxdnp147ftrzv8
    1svlfzctbrbjprkmpz4xtbccfxhnvfqmhzt68
    fourqsgxnxthreeeighttwo2seven1nine
    57sixsix2sevenvkxrsevencmmgv
    5jlkfmtwoseventhreeoneightbsr
    zpsevenfouronexftsphg731
    15twosix774
    bbpthreeonenpkknbxn2kdqbrbr
    dc7mqnzhmtdfr18
    fivefivethree75two7three
    lbqvxmgfivenine3ninefive1
    sgpnsmdqb5seven8eight
    hclzmmbt3gthnf
    lpxtfzvs6twosevenfour1dxrdnkfive
    onektc4three
    337
    nflntqzlcfourgbgkcldrvbx8five53
    8nkmkssgmlgmxhvpdgjseven
    nine78twohnthree9
    9ninesixgtjqbksix392
    sevenonegfmlxzzrm35nt
    xmmrcjtspfive8sixsixt1
    tpbdxblvfqblcqndseventhree22
    2shhzch
    fourtwo5ssdmsn51eight
    9rvxckfrrvsix
    tgfcgdm1qsx3four2eightcctqd1
    kxqfltbrfhpkbsmtthreethreeone3
    zrxprsixfiveone8bvbdmxjzbmthree
    fpqjfcpheight4twofive5kpcnntbnnq4tcfbkqh
    bhjkzdmmrfivetsxlhthreeddchsix5
    5tck83cseven9nine
    two2three
    6oneighthlf
    572hcvfdbgt9twoonechngccmqc
    74eightrvtconebgjbpnqlslcs
    nbmntwolntd1zvzplfzthree11seven
    kpzfgpxdonesix2fourninefourfour
    fbdqzbmjnkmqcgeight5five
    425six14two46
    jhctmxconelfkgmprnfourseven8twofkjvlvnjgd
    twonrpvnnmvkh2threejzcpz"

module Day02 =
    let day2p1example = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
    Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue
    Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
    Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
    Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green"

    let day2p1 = "Game 1: 5 red, 1 green; 6 red, 3 blue; 9 red; 1 blue, 1 green, 4 red; 1 green, 2 blue; 2 blue, 1 red
    Game 2: 12 red, 2 green, 9 blue; 8 red, 12 blue; 9 red, 1 blue, 2 green; 12 blue, 8 red, 2 green; 4 red, 5 blue; 1 green, 9 blue, 10 red
    Game 3: 2 red, 8 blue, 5 green; 10 red, 10 green, 7 blue; 9 green, 13 red, 5 blue
    Game 4: 3 red; 1 blue, 3 green, 3 red; 3 blue, 8 green, 5 red; 8 green, 2 blue
    Game 5: 8 blue, 1 red, 1 green; 1 blue, 1 red, 7 green; 7 green, 5 blue
    Game 6: 2 red, 8 blue; 5 blue, 4 green; 5 blue, 4 red, 3 green; 3 red, 9 blue; 5 green, 9 blue, 7 red; 6 red, 9 blue, 5 green
    Game 7: 3 green, 4 blue; 7 green, 3 red, 3 blue; 7 red, 4 green, 6 blue; 4 blue, 1 green, 5 red; 6 blue, 2 red, 7 green; 1 green, 4 blue, 4 red
    Game 8: 2 blue, 12 red; 1 green, 2 blue, 10 red; 12 red, 10 blue; 5 red, 1 green, 2 blue; 13 red, 16 blue, 1 green; 2 blue, 18 red
    Game 9: 5 green, 2 red, 13 blue; 5 green, 1 red; 7 green, 8 blue, 1 red; 16 blue; 5 blue, 2 green, 3 red
    Game 10: 5 blue, 2 red; 13 blue, 3 red, 5 green; 2 red, 3 blue; 6 red, 9 blue, 5 green; 9 blue, 3 green, 3 red
    Game 11: 9 red, 4 green, 3 blue; 8 blue, 8 red; 1 green, 13 blue; 11 blue, 8 red, 4 green
    Game 12: 1 green; 1 blue, 4 red, 6 green; 1 red, 8 green; 7 red, 1 blue, 3 green; 8 green, 1 blue, 8 red
    Game 13: 5 blue, 14 red, 1 green; 10 red, 4 blue, 1 green; 6 red, 1 green, 3 blue; 7 blue, 4 red; 14 red, 2 blue, 1 green
    Game 14: 9 green, 1 blue; 6 red, 9 green; 7 green, 3 blue
    Game 15: 1 green, 4 blue, 2 red; 8 red, 3 blue; 1 red, 3 blue
    Game 16: 6 blue, 10 green, 5 red; 11 blue, 1 red; 3 red, 2 green, 3 blue; 1 green, 4 red, 6 blue; 11 blue, 2 red, 11 green
    Game 17: 4 green, 5 blue, 8 red; 6 green, 7 red; 3 green, 8 red, 5 blue; 4 green, 8 red; 5 green, 11 blue, 3 red; 5 green, 15 blue, 1 red
    Game 18: 7 green, 17 blue, 14 red; 4 green, 11 red, 7 blue; 13 blue, 8 green; 3 red, 7 green, 11 blue
    Game 19: 13 red, 13 blue, 1 green; 7 blue, 1 red, 5 green; 18 blue, 1 green, 11 red; 4 blue, 13 red, 6 green
    Game 20: 1 blue, 6 green, 7 red; 5 green, 4 red, 1 blue; 1 blue, 1 red, 4 green
    Game 21: 3 red, 5 green, 7 blue; 6 green, 10 blue, 5 red; 9 red, 1 blue; 5 green, 8 blue, 9 red; 2 red, 11 green, 4 blue; 5 red, 6 blue
    Game 22: 8 blue, 1 red, 1 green; 10 blue; 13 blue, 1 green, 4 red; 1 green, 8 blue, 4 red; 3 blue, 1 red
    Game 23: 2 blue; 3 blue, 5 green; 6 blue, 5 green, 2 red; 1 green
    Game 24: 1 red, 13 green, 4 blue; 16 green, 4 blue; 4 red, 5 blue, 11 green; 15 green, 5 red, 10 blue; 16 green, 1 red; 5 red, 3 blue, 10 green
    Game 25: 12 red, 7 green, 6 blue; 5 blue, 5 red, 12 green; 12 green, 3 red; 5 green, 5 red, 3 blue
    Game 26: 2 green, 11 blue; 5 red, 3 blue; 5 red, 12 blue, 3 green
    Game 27: 3 green, 5 red, 12 blue; 3 red, 11 blue, 1 green; 3 red, 4 blue, 3 green; 3 red, 9 green, 9 blue; 14 blue, 1 green, 12 red
    Game 28: 8 green, 9 blue; 6 green, 8 red, 1 blue; 7 red, 6 green; 12 red, 2 blue, 2 green
    Game 29: 16 red, 4 green, 1 blue; 10 red, 7 green, 2 blue; 3 green, 8 red; 2 blue, 1 red, 4 green; 2 blue, 10 red, 9 green; 7 green, 1 blue, 18 red
    Game 30: 13 red, 3 blue; 3 blue, 1 green, 10 red; 15 red, 3 blue; 1 green, 1 red, 1 blue; 16 red, 1 green, 3 blue
    Game 31: 5 red, 8 blue, 3 green; 5 green, 7 blue, 13 red; 9 red, 3 green, 10 blue; 15 red, 1 green, 7 blue; 5 green, 12 blue, 2 red; 6 blue, 13 red
    Game 32: 2 blue, 8 red, 1 green; 3 green, 2 blue, 11 red; 2 green, 6 red; 13 red, 3 green, 2 blue; 6 red
    Game 33: 5 blue, 5 red; 8 red, 1 green, 7 blue; 1 green, 6 red
    Game 34: 3 blue; 3 green, 2 blue, 2 red; 3 green, 1 blue, 3 red; 3 blue
    Game 35: 4 red, 2 blue, 6 green; 4 blue, 9 red, 10 green; 3 blue, 8 green, 1 red; 3 red, 1 green, 4 blue; 4 green, 7 blue; 8 red, 8 green, 2 blue
    Game 36: 1 red, 3 blue, 12 green; 16 green, 7 blue, 1 red; 1 blue, 1 red, 9 green; 2 blue, 2 green; 8 green, 2 red
    Game 37: 2 green, 8 red; 3 blue, 1 red, 2 green; 15 red, 7 blue; 1 green, 16 red, 15 blue; 13 red, 9 blue
    Game 38: 9 red, 9 blue, 5 green; 3 red, 19 blue, 8 green; 15 blue, 11 red, 6 green; 10 red, 19 blue, 5 green; 8 blue, 7 green, 6 red; 7 red, 6 green, 10 blue
    Game 39: 8 blue, 13 green, 2 red; 16 blue, 9 green; 19 blue, 1 green; 1 red, 3 blue, 9 green; 1 green, 18 blue
    Game 40: 6 red, 5 blue; 11 green, 15 blue, 7 red; 10 blue, 5 green, 10 red; 13 blue, 9 red, 11 green; 2 green, 14 blue, 12 red; 6 red, 6 green
    Game 41: 10 green, 1 red, 1 blue; 1 red, 9 green; 1 green; 6 green, 1 blue, 2 red; 1 blue, 8 green, 1 red; 9 green
    Game 42: 13 green, 2 blue; 10 blue, 1 red; 10 red, 10 green, 8 blue; 16 green, 8 blue, 6 red; 9 red, 18 green; 10 red, 15 blue, 1 green
    Game 43: 3 red, 16 blue, 6 green; 1 red, 17 blue, 12 green; 19 blue, 2 red, 16 green; 12 green, 7 blue, 1 red; 8 green, 7 blue, 2 red; 12 green, 9 blue
    Game 44: 4 red, 3 green, 2 blue; 18 blue, 3 green; 7 red, 7 blue, 4 green
    Game 45: 1 green, 3 blue, 7 red; 9 green, 8 red, 2 blue; 5 green, 3 blue, 6 red
    Game 46: 18 blue; 4 blue, 1 red, 5 green; 2 red, 15 blue, 7 green
    Game 47: 17 red, 4 green, 12 blue; 6 green, 1 red, 2 blue; 3 blue, 13 green, 4 red
    Game 48: 11 red, 2 green; 8 red, 3 green; 2 green, 5 blue, 9 red; 3 green, 2 blue, 5 red
    Game 49: 2 green, 12 blue, 9 red; 1 green, 12 red; 1 green, 2 blue, 18 red; 8 blue, 19 red; 1 green, 5 blue; 3 blue, 10 red, 1 green
    Game 50: 5 green, 1 red; 7 red, 3 blue, 9 green; 15 blue, 4 green, 4 red
    Game 51: 12 green, 14 blue; 2 red, 5 green, 16 blue; 4 red, 17 blue, 16 green; 6 blue, 16 green, 2 red; 17 blue, 13 green, 5 red
    Game 52: 7 green, 10 red, 2 blue; 6 green, 12 red, 3 blue; 10 red, 3 blue, 8 green; 3 blue, 1 green, 8 red; 6 green, 5 blue, 3 red
    Game 53: 8 blue, 3 green; 7 green, 11 blue, 1 red; 1 red, 7 blue, 9 green; 1 blue, 1 green; 4 green, 1 red; 1 red, 8 blue
    Game 54: 1 blue, 1 green, 4 red; 1 red, 1 blue, 13 green; 11 red, 11 green, 1 blue
    Game 55: 5 blue, 4 red, 11 green; 13 green, 9 blue, 3 red; 3 red, 7 green, 8 blue; 2 red, 20 blue, 2 green; 3 red, 10 blue, 1 green; 12 green, 5 red, 8 blue
    Game 56: 17 red, 2 green, 1 blue; 13 blue, 8 green, 6 red; 1 green, 9 blue, 6 red; 2 blue
    Game 57: 9 green, 1 red, 9 blue; 15 green, 10 blue, 1 red; 5 blue, 3 red, 10 green
    Game 58: 14 red, 2 blue, 14 green; 17 red, 7 blue, 10 green; 4 green, 13 red, 11 blue; 3 green, 13 red, 5 blue; 13 red, 6 blue; 1 red, 7 green, 2 blue
    Game 59: 16 blue, 7 red, 2 green; 7 green, 10 red, 12 blue; 4 red, 9 green, 14 blue; 8 blue, 11 green, 1 red; 3 blue, 5 red, 11 green
    Game 60: 1 blue; 9 red, 4 green; 3 green, 3 blue, 1 red; 3 red, 1 blue
    Game 61: 2 green, 15 red, 12 blue; 9 green, 1 blue, 10 red; 14 blue, 17 red, 2 green; 12 red, 6 blue, 3 green; 8 green, 10 blue, 10 red; 2 green, 10 red, 2 blue
    Game 62: 12 red, 6 blue, 1 green; 2 red, 1 green, 4 blue; 10 blue, 12 red, 4 green; 5 green, 8 red, 8 blue
    Game 63: 3 green, 3 red; 7 red; 2 green, 1 blue, 7 red; 5 red, 1 green
    Game 64: 5 green, 11 red; 4 green, 2 blue, 7 red; 7 red, 11 blue, 3 green; 8 blue, 5 green, 5 red; 8 red, 4 blue
    Game 65: 5 red, 5 blue; 15 green, 3 blue; 3 blue, 3 red, 8 green; 1 blue, 3 red, 5 green
    Game 66: 8 green, 5 blue, 12 red; 10 red, 5 blue, 11 green; 12 red, 3 blue, 2 green; 5 green, 1 blue, 10 red; 15 red, 5 green, 3 blue; 2 red, 8 blue
    Game 67: 12 blue, 3 red; 4 blue, 4 red, 1 green; 9 green, 14 blue, 3 red; 2 red, 13 blue, 6 green; 17 blue, 5 green
    Game 68: 1 blue, 4 red, 11 green; 11 green, 4 red, 7 blue; 11 green, 7 blue; 14 green, 2 blue, 1 red; 2 blue, 4 red
    Game 69: 4 red, 1 green; 5 red, 2 green, 3 blue; 1 red, 7 blue; 8 red, 6 blue, 1 green; 2 green, 6 red, 1 blue; 6 red, 8 blue, 2 green
    Game 70: 6 blue, 2 green, 4 red; 1 green, 5 blue; 1 blue, 3 red; 2 red; 2 red, 17 blue
    Game 71: 9 blue, 2 green, 1 red; 7 blue, 2 green, 3 red; 12 red, 13 blue; 15 blue, 1 green, 1 red
    Game 72: 15 blue, 16 red, 18 green; 16 red, 12 blue, 14 green; 3 blue, 12 red, 4 green; 8 green, 17 blue, 15 red; 15 blue, 18 green, 4 red; 5 blue, 3 red, 10 green
    Game 73: 17 blue, 3 red, 19 green; 10 blue, 15 green, 18 red; 4 green, 15 red; 1 green, 17 blue, 14 red; 16 red, 1 green, 4 blue
    Game 74: 6 green, 2 blue, 5 red; 1 blue, 9 green; 5 red, 1 blue, 10 green; 4 green, 11 red, 1 blue
    Game 75: 4 blue; 4 green, 6 blue; 2 green, 2 blue, 4 red
    Game 76: 5 blue; 5 green, 5 red; 9 red, 1 blue, 1 green; 5 green; 3 green, 6 red, 1 blue
    Game 77: 2 red, 10 blue, 6 green; 1 red, 6 blue, 6 green; 9 blue, 2 green, 8 red; 12 blue, 7 green, 18 red
    Game 78: 2 red, 5 blue, 2 green; 2 blue, 4 green, 6 red; 4 blue, 4 green, 3 red; 3 red, 5 green; 2 red, 4 green, 4 blue
    Game 79: 14 red, 6 blue, 1 green; 6 blue, 18 red, 2 green; 1 green; 8 red, 5 green; 1 blue, 7 red, 6 green; 11 red, 1 blue
    Game 80: 5 blue, 4 red; 19 blue, 7 red; 6 red, 1 green, 12 blue; 1 green, 8 red
    Game 81: 7 green, 6 red, 9 blue; 14 blue, 8 green; 15 green, 6 red, 4 blue; 1 red, 7 blue, 19 green
    Game 82: 1 red, 4 blue; 3 blue, 1 red, 5 green; 3 blue, 5 green, 12 red; 17 red, 2 blue; 4 blue, 1 red
    Game 83: 6 blue, 11 green, 18 red; 11 red, 7 blue, 2 green; 13 red, 14 blue, 14 green; 1 red, 3 blue, 16 green
    Game 84: 2 red, 5 blue, 3 green; 9 red, 7 blue, 2 green; 4 green, 9 red, 3 blue; 1 blue, 1 green, 5 red
    Game 85: 1 red, 10 green, 15 blue; 9 green, 1 red; 1 red, 2 green, 12 blue
    Game 86: 1 green, 5 blue, 8 red; 10 green, 8 red, 9 blue; 6 green, 3 red, 8 blue; 9 red, 3 green, 8 blue; 2 red, 6 blue, 1 green
    Game 87: 13 red, 12 green; 6 blue, 5 green, 3 red; 10 green, 1 blue, 17 red; 9 green, 6 blue, 2 red; 1 blue, 9 green, 14 red
    Game 88: 4 green, 1 blue, 7 red; 6 green, 2 red, 1 blue; 13 red, 7 green
    Game 89: 2 blue, 7 green, 10 red; 6 green, 5 blue; 12 red, 4 blue, 5 green; 15 red, 8 blue; 6 blue, 8 red, 3 green; 14 red, 11 green, 16 blue
    Game 90: 8 green, 8 red; 5 green, 1 blue, 13 red; 3 blue, 1 green, 3 red; 11 red, 2 green; 9 red, 7 green, 1 blue
    Game 91: 4 green, 13 red, 10 blue; 11 blue, 4 red; 10 blue, 9 green; 9 green, 4 blue, 12 red; 7 green, 4 red, 1 blue
    Game 92: 6 blue; 10 green, 1 red, 11 blue; 5 blue, 5 green; 6 green, 1 red; 1 red, 6 green
    Game 93: 2 red, 15 blue, 4 green; 13 red, 11 green; 6 green, 1 blue, 6 red; 6 red, 5 blue, 10 green; 2 blue, 11 green, 18 red
    Game 94: 2 red, 13 blue, 3 green; 15 blue, 4 red, 2 green; 4 green, 9 blue, 7 red; 12 blue, 6 red, 11 green; 20 blue, 13 red, 11 green
    Game 95: 6 blue, 1 red, 10 green; 10 red, 5 blue, 7 green; 9 red, 13 green, 10 blue; 11 blue, 9 red, 8 green
    Game 96: 2 red, 7 green, 16 blue; 20 green, 2 red, 14 blue; 5 red, 15 green, 15 blue; 4 blue, 6 red, 15 green; 6 green, 6 red, 10 blue
    Game 97: 1 red, 1 blue, 14 green; 10 green, 12 red, 1 blue; 10 red, 2 green, 1 blue; 1 blue, 3 green, 14 red; 3 red, 2 blue, 13 green; 1 blue, 3 green, 13 red
    Game 98: 13 blue, 1 green; 18 green, 6 red, 3 blue; 11 blue, 7 red, 9 green; 4 red, 6 green, 11 blue; 12 blue, 6 red, 8 green
    Game 99: 4 blue; 1 red, 2 green, 11 blue; 12 blue, 1 green, 1 red; 11 blue, 6 green; 1 red, 7 green, 8 blue
    Game 100: 10 blue, 5 green; 4 green, 3 red, 6 blue; 2 green, 4 red, 1 blue"

module Day03 =
    let day3p1example = "467..114..
...*......
..35..633.
......#...
617*......
.....+.58.
..592.....
......755.
...$.*....
.664.598.."
    let day3p1 = ".......358..........31.....339.....669.............598......328.....575......................447..650..............964...........692........
...............415..*.........@......*...627*...................945*.............144/.506............................*......514...*...150...
.........182..+.....873.756.......737........784..568....667..............258........./.........741...........707*....84........520.........
..579...@.........$........*..........258.................*.........274..*.....739.......157./.....*580...........893.....696*........889...
.....*.........875.........173.........*..................109...896*......959...*........=...677...........&636.........................$...
......961..$............-...............907...569....#...........................756.....................................681................
...........478...616.....30.....221*...............552.../33...258*343.....488........*682...526..*.........422...........&..........764....
................+..........................................................*................*.....7...550..........=.........878............
...171..275............#.....................401....50.$.................43...............123.............../949..135..331.....@.495........
........*...48@.662.100...............590...*........#.566.....................15..../426.............774...............+...........*.......
...944.28.........*.....................*....307...........410.361....55..................24.447.*......*....787*...266....361.......161....
....*...........405.&...=785...146......654.......281.............*.....+...................*....760..80..17.....84....*..+.................
.....830...140......745.........%..$..........972.......406*864..762..............695.327.................*...........512...................
............*...............#......414...........*..960...............1..............*.................374.....264.............833....336...
.......-.252.......10....518..................777...=...811..103.454..*....................774*433.........951*....826........@....=...*....
.....44..............*................-....................@..$......957...............216..........=..................614........521..232..
.........=232......802...+779.....759..307....................................%941.......*........512.............865.....*.................
...................................*.......162...662....816.681.....21*................290.........................*......364..........=....
.................258....195.........1..535......*.......*.....*........261............................650.......152.................514.....
..425...411@...../.........@...........*.....788.........186...91.279............-.....................*............268.......639.......864.
....................................=.933........../.................%...%........73........%203....187..362...861.....*389.....*.......*...
...254....847............@........135......6.......529..........202......96...........840.........@........*...*.../.........998.......989..
.........*.....288......650............349*.......................%.609...................526.....655.....854....425..............531*......
..../....848....&..............505...........................594..........434.................@.......$68............767..............732...
.410...............585...............185........................*...91........773..579........454............757.....*....568..+742.........
..............................*70.......*......478............769....&.182.......%.*..................568......-.570.861....*...............
..............*993.48......893........835....*..*......*.................*..........798..473.........../....................965...691.......
...........306.......*............531.......938.200.335.432...343.....360......836......-...........*..........951.691..............*.......
...341*360............958............*.........................#.........../.....*.../........728..585.........*.............902=..696......
.............190...................808..451........+..................272...59.641...822.........*..........289...36...................509..
..464*10.604.+....241.102%..............*...633.450......................+........................797............*.......575..........*.....
...........-............................488..........402.....936.847................+.......434.......................&.....&....844...478..
......147..............826...297................257...*...........*.....$.....932...492..81...%....829..........560...661.........*.........
.........*....379.......*....*...884..700.......*.....646..........914..659...............*....................=..........513/..621..790....
.369....472..*.......843....734....#.+....%...738........................................989............501.......817.375...............@...
..............727.........................131.....767..........=......665...685..............747..727.......868..*.............478#.........
........247.............-...........649.............*..*82..507...............*..................................504........................
.........*...........909...............*.....707..922..............701...213.833.866$.630...&..606+....................102.183@..*281.225...
...465.108...............772.....915.109..96.%...................../.....*.............*..685........155....811*...220.*...............*....
.................106.....=.................&........*........*488.........233.......590........$551.....*..........+...287.#874..%....956...
....................*513.........&...............829.487................................350..-........338.......55................464.......
....&............@............695......227................$.793.............802.....294...*...822..........960....*....295..946.............
....587...........859...204.......246*....*644.........925.........167.210..../..........129.............%....*...102.....*..*..........832.
.......................*..............558.......404.......................%..........................817..870.791......120..483..406...$....
....797%..68....929-.87....411............*........*.............458*143....721.-....706.......694....*.........................+...........
...........*..................*........369..........899..79................*....417.....*930..*........78.....@174.........276..............
.313........394...750..........773.........................................916......37+.......384...........-......355.203....*.....180.....
....@...902...........829.......................................*823........................*.............408.......*......960......*.......
........*......%........#...........@871..........756.........22.........956..............56.622.=461.823..........749...........297..557...
......877.......863..............................*.........................=.968..............................12.......946%..........%......
..............................123.39.551...12...700..507*....................*........320.........*...54....................................
.............583........424..................$...........571......#.......499.......-.............803......92.&......942..........782.......
....726.....$...............=....688.580...*...........#..........905............446....397...................629...*............*..........
.....*..758.......831........760..-....*.427......473...729............298...618........-.........562*865.........553....267...12...........
.................$.....971...........472.....61....#..................*.........@..714.......712............173.............*......-780.....
.....*948..........&.....*..750.311..................*425.193....@336..882........*..........*....913.........*...........369...............
..942..............209.791....-....%.626.787..812.954......................725/.806.%...............#.......447....679..........706...11....
...............922......................*................217@......962..............9.104...806...................%.....278*.....*..........
.........382......*........./.......346.......346....448............*....................$...................*................820..454%.....
.315......./....418.........748................%...............577..655.......*254..266.....383*...$......316.243.........*.................
.....................363................709.....................=..........714..........224......479...................817.428....../.......
......................*................*........318................237....................*...................497.152............457........
...........911........756..589..........562......=..253........8*................498...392.......394.768...@................................
...............$..751..........856...................*...56......202...201.........+................*.......525.......430...................
.193........953...*.....456..@................310*........*............../.58@.........*..............863..........$....%..675..+117...447..
.......940.................*.905.889......542.....723......591....*956.........743.$..156.........791*......923..84......../..........$.....
.........&.....538&......643......*..=......*..................659............@....66.....681...............................................
.................................127.585.238.......-866....654......................................393................80..19..979..........
.........................300.................102........................465*..............705.332......................%.........*.....*142.
......+....#.....*...500..%..336.419........*....+116.719...........237.....81...461*931.....*.........613.#426...................434.......
......489.420.459......*......*....*.....277.............%.........=...............................*..............746....512............%848
.......................804....445.197.........658.*342....................+461.630......%...930@....804.504........*.............+..299.....
...........270.....257........................./.........283....................*.......357.......................702.....644.587......*....
...460%...=...........*.......406.........162..............*...259.......*.......121.............360$.#...76..228.....847..*............666.
.....................612..178*.............*...527*872.762.267........307.606.........#........$......224....&....13*....-.455.......&......
..........152.......................919..485............/.........70.................623....968......................810............281.230.
......693.*...520............$......*...........*909.....................586.........................794......229.........88...385..........
..363*....636..*......619.....238....45..............982...........*145.....*803......-.......426.......#.....+.......213*...#....*.........
...............536.....+........................&.......*.......708.....170......360..220......*../.......16................796....283..564.
.652....&...........$.....*....................89...944.894................*....-............975.27...409*...978......./445.................
...*.538...........822.274.491.....-..........................572.........329.........*468......................&.......................213.
.47......568.......................706.....232....74..490............&965..........685................125...........................824*....
........*....725...........#548............=......*.........................................77*391...*........253...............767.........
.......769...&......................183........687..921......913$...@.....162...724.................220.........*...880.834.........404.....
...+.................466...%411...../...............*...............894....*.......*.............*............196.....*................*....
.90.......423..../......*.......1.........-.......360.....233...............2........=......@....422.....334.........878......322......573..
....649..........475....450....%......-....249.................905.............760..879......829..........-....................*............
......*......290.....................680............/............/.244&.........................................9.596.326.........359.......
...............*........200.....723................826....773...........576..790..=..............642.................*....617....*.....649..
.....#979....776..562.......@.....*........................#........363.....&....915..704....401....*...32*681.%261.......&.......351.......
896*.................*896...493.88....*.........622.............925*.................*....17*.......265..............893....................
....778.%222.......................873.872..........635@...852..........559........456..%......*128........179.......*............336*......
.................985.......................77...482.........-.......502*......404......206...41......631..*.........761...............782...
.....194...........&...............514*130..=..*.............................*...........................168.............../..46+...........
.............207...............................195.....619..$..........544..191.......419*842....64......................206..........816...
..............................670..84*78.................*.966......%.....*.....................*........=............................*.....
.564.........185-........250....*........464...762.....412.......302.....27..764.653/.738*596..........563....741.........13.148.......928..
....*.............%..565....%.60....+158..*...$............*503...................................824.................284.......*.931-......
....710...763...272..*...................851..../....................456.......121....603................3..445...............382.......837.
....................956..970........-..........377......381.......56.......926........../......135......*....../.........315........172.&...
........201.............+...........261.517..................606........../.....347......................655.......717........468..*........
...746...&...332...............681...............703...........*.....=............*...........................................*....824......
......-.........*478.............*.....595.245....*...918.....875...875.........965...........676...745*...858...479.......132..............
..354........*.................776.-...*...*...820...../..%..............291........../........*........59.*........*....................485
...&......668.956......738.........921.312.803.....770...613....78*522..&...........665......692............253......863............537.....
...................498......258...................................................................426.........................#.............
.....108..........&.....357.-......794..594#............#............255........$.........664.525./....885...$..............353..823........
........+...590..........*........*...........111.......420..374..............144...........*...*...80*.....164...928...427......&..........
...+...........*..289.185......$...659.772/....*.............*........361..........504.........436...................*......@...............
...14....*...296...*........453..............753.368.733...167..675....*....................................22........502..443..............
.......413........................200=..616.......+...*...........#.....143..768..........404.............@...=...102..............378......
...538..........579.......................=...........311.267...................*.....445...*.....%138..158............#...........*....323.
......$............/.................586%.........825.....*....................318......@...260.................618..229...865....353...*...
.............834.......68*981................606..*.....432............870...............................749....*...........#.........215...
......886....*...325...................18.25*.....977...................../.......385.........$.......95*......182./........................
............773........................*................165...+....+816........*...*...........391..................439............@........
........................682..........249...................*.435............400...261..119.....................................921..630.....
.......-.......92*744....*....................115.......780........205....................*...347.152......950..592&.152....@.....*.........
.....789.949..............530.248.149.............................*....*957............957.....&..*.......#..........#.....572..............
...........*.601.766..112.......*......113..@.....529...736.+...656.837........320...............518.120.........125..............900.......
83......434.....*.....*.../...224.....*....235..............498............175...*.930.......................+......*................*880...
...*296...............118.328........405.............../801................*...804....*.......................590...770.........276.........
297..............726.............................966............*997......165..........25.983............669.............&..992*.......966..
...........92....*........%.........108.............@.475....769..................897......@.........792................123.......122.......
...........*...&..579......811..708...&.................*........................*....767.......386...........558............708.....=......
........230..161...............*................#....177.........940...903./...706.......*785..=.....93..381..%.................*...........
...621.............652..886...157........$....204............418....*....%..62......422.............*.....=........555.537.............+479.
.....%............*.....*.............499............96.........*....656..............*...751..293...759.....174..........%..265..32%.......
...............610....105.416.........................%........242.........*.......746.......*....=...........*..259@.......................
............#................*591........./.-.......................653.103..62=.............585.............567...........586...+....216...
..840/....612.......588.................676..202...................&................@..............................301............632..*....
......................*.........=392.............667..%..........-...............457...134*....................165*.....................728.
.339&.*74.........402.581............518&.......*....823.....874..102..678.74..............219....114..................836..915..245.-......
..........38.....*........612...628..............90......513...*............*...........59......+..../....799..268....*.....*.........370...
..........$........./........*.....*.......$...................8.......684=.577..209.........550.............#.....#...529.240..............
.236..............153......163........*.414...........................................549........432............919............81.....-337..
....*.................604......-...631..........879........240.......97...............*.....315....&...720..........610...530...............
.....856...214..236....*.....159.%......738.....-......826....&.272.*.......36.....465.........../.....*...587.......*....*......548..699...
.............*........36..........743.=.../...............*......*..424.................580.#...897.448....*.......833...633.....*...*......
.............963......................542........734.....901...914..........843.............523..........818..................691.....833..."
    let day3p2example = ""
    let day3p2 = ""


module Day04 =
    let example1 = ""
    let p1 = ""