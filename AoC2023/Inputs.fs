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
    let example1 = "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53
Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19
Card 3:  1 21 53 59 44 | 69 82 63 72 16 21 14  1
Card 4: 41 92 73 84 69 | 59 84 76 51 58  5 54 83
Card 5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36
Card 6: 31 18 13 56 72 | 74 77 10 23 35 67 36 11"
    let p1 = "Card   1: 47 10 77 75 94 50 93 43 27 18 | 73 75 32 65 98 76 71 13 50 78 54 94 18 83 77  6 79 93 45 27 87 57 51 55 43
Card   2: 17  9  7 91 32 97 76 39 83 88 | 88 25 46 50 91 18 39 76 17 22 28 82 44 66 52  7 11 56 77  9 40 83 97 32 47
Card   3: 32  2 10 96 30 37 60 86 88 50 | 64 96 58 41 24 37 86 84 80 49 30 53 83 50 42 33  2 52 88 46 19 89 32 51  5
Card   4: 62 21 85 90 64 44 29  2 86 84 | 98 21 82 55 62 14  3 33  7 90 85 57 94 44 64  5 43 91 96 67 84 78 69 81 29
Card   5: 85 28 74 24 52 88 22 50 66 61 | 93 43 52 91 66 88 53 82 87 22 47 69 74 28 50 85 83 24 42 23 46 61 76 37 41
Card   6: 79 36 65  7 77 38 57 68 59 80 | 83 67 80 77 47  4 42 22 54 79 66 57 98 84 41 65 86 61 38 63  7 36 31 59 68
Card   7: 69 27 99 35 40 53 13 32 15 28 | 51 15 25  6 69  4 11 34 99 78 40 53 68 97  3 76  9 72 82 74 13 83 30 35 42
Card   8: 94 25 10 47  2 50 17 27 88 23 | 47 61 48 10 45 23 96 88 80 30 58 53 50 33 12 25 41 17 28  2  7 27  5 49 94
Card   9: 21 61  7 78 50 53 25 36 80 26 | 30  6 77 16 61 99 54 23 86 26 56 21 43 42 20 36 80 53 73  4  5 78 96 57  7
Card  10: 13  7 64 98 19 16 77 55 80 15 | 24 64 71 13 14 79 76 34 43 40  1 91 68 56 19 52 75 63 55 89 74 22 45 92 77
Card  11: 18 53 37 44 72 92  6 85 46 29 | 62 27 16 31 76 91 60 46 36 44 85 49 59 98 73 25 15 53 67 10 61 58 50 77 32
Card  12: 12 80 86 59 33 82 81 89 97 42 |  6 22 70 64 62 88 27 25 60 56 36 19 96  4 98 66 71 76 94 57 11 15 55  3  7
Card  13: 68 57 80 11 42 56 98 63 61 95 | 68 12 21 93 53 50 80 63 72 42 98 57 34 44 95 43 74 58 17 94 11 23 40 79 31
Card  14: 82  6 65 18 67  3 48 81 28 96 | 96 71 25  8 81 38 97 19 82 67 78 48 36  3 18 30 28 94 31 29  6 20 41 16 76
Card  15: 77 46 11 22 70  1 47 67 57 23 | 88 35 37 81 26 27 10 82 75 14 97 93 41 80 12 49 94 24 89 64 87 45 28 17 42
Card  16: 40  9 49 69 59 25 37 91 27 11 | 91 27 84 37 64 86 68 33 36 69  8 75 34 47 80 71  5  9 93 23 31 29 51 82 88
Card  17: 96 50 25  6 90 67 27 98 99 88 | 79 80 16 49 39 43 71 83 82 78 40 89 54 50 38 66 86 28 55 56  6 35 74 29 23
Card  18: 61 30 69 53 76 32 29 45 26 79 | 60 69 82 78 31 72 91 13 92 40 24 54 25 14 22 87 70 35 18  7 96 86 49 15 66
Card  19: 22 15 99 66 94 96 59 69 91 24 | 15 34 13 78 21 32 89  8 25 93 16 97 31 24 67 85 46 53  9 81  7 83 33 28 79
Card  20:  4 96 82 86 40 24 99 72  6 50 |  6 56 29 77 76 18 48 20 45 80 46 60 81  5 19 55 94 27  9 64 53 12 82 79 83
Card  21: 25 54 50 91 12 14 99 17 21 60 | 94 45 83 79 66 81 31  8 53 26 65  2 62 88 22 43 52 40 18 70 37 15  6 61 50
Card  22: 24 87 19  1 91 23 18 29  3 15 | 54  9 31 92 81 71 25 76 65 45 21 47 17 32 56 30  5 84 20 58 50 11 99 79 42
Card  23: 10 59  1 14 55 72 41 65 92 85 | 99 50 83  3 97 66 33 32 91 40 25 62 78  7 31 90 77 93 43 79 96 86 57  5 48
Card  24: 95 26 66 37 10 79 93 30 31  2 | 31 56 88 19 89  5 33 40 58 79 93 96 78  1 62 65 85 67 70 24 43 75 66 27 38
Card  25: 42 73 24 97 78 95 67 81 59 88 | 15 96 55 60 97  4 67 98 95 21 73 19 57 24 58 82 61 99 31 70  9 91 78  2  1
Card  26: 40 64 83  9 50 49  2  6 36 52 | 67 64 79  6 27 85 34 36  5 83 92  4 58 68  7 75 14 94 28 76 37 97 26  8 33
Card  27: 49 82 22 26 57 95 91 37 53 55 | 82 58 75 12 53 13 26 41 55 40 22 71 91 30 80 88 57 49 37 73 96 95 10 76 21
Card  28: 82 10 94  1  7  4 13 66  2 99 | 30 68 54 85 12 23 96 36 33 61 38 75  7  5 74 10 48  2 42 66 98 70 89 55 97
Card  29: 60 99 69 43 54 26 39 34  3 70 | 78 93 63 89 91 42 56 11 77 71 73 86 82 70 65 54 27 99 85 29 61 72 37 39 96
Card  30: 43 59 42 61  6 19 69 13 83 56 | 19 35 29 89  7 83  3 90 84 48 34 33 17  2 94 12 44 70 62 51 32 36 58 63 81
Card  31: 18 48 58 97 80 14 24 91 55 88 | 28 34 86 55 50 17 14 54 84 80 48 93 38 58 23 88 15 96 97 56 31 59 91 61 24
Card  32: 75 70 54 21 43 11 60 48 55 17 | 86 75 34 68 11 35  4 25 54 14 90  6 20  1 70 33 49  7 17 87 16 24  9 77 44
Card  33:  4 14  9 60 55 84 91  6 51 56 | 65 40 81 98 58 76  9 60 51 75  2 39 55 15 62 26 88 84 12  7 83 67 91  4 38
Card  34: 24 43 34 86 93 61 76 29 46 15 | 64 59 62 88 21 72 34 44 27  9  8 48 82  2 63 66 98 33  3 97 68 93 65 60 87
Card  35: 78 87 30 41 55 62 82 79 95 19 | 47 60 92 11 31 13 21 43  2 12 91 76 74 51 15 24  9 32 18 85 98  1 35 42 34
Card  36: 13 76 89 25 41 96  1 29 77 35 | 45 81 17 33  5 87 73 92 53 75 14 79 27  1 34 13 11 24 62 26 68 12 23 54 88
Card  37: 87 95 57 77 21 79 93 47 72 99 | 71 28 33  7 90 30 19 76 34 35 77 98 87 51 83 24  3 60 80 52 53 13 55 16 69
Card  38:  8 74 16 51 45 10 41 13 89 90 | 38 35 56 29 46 59 69 27 63 72 20 83 51  4 77 87 75 12 67 26 85 62 30 37 43
Card  39: 33 25 24 89 79 50 72 45 88  6 | 66 37 12 10 43 51 55 40 36 52 94 62 60 85 97 72 22 59 82 80 29 39 70 57 48
Card  40: 53 10 41 67 62  9 88 33 55 61 | 43 86 29 93 15 26 74 95 94 56 90 47 89 92 19 82 81 20 97 57 37 73  3 63 18
Card  41: 82 39 81 58 32  5 40  6 38 96 | 68 60 38 74 66 49 58 28  6 90 53  5 95 50 82 18 67 13 83 76 35 81  3 10 20
Card  42: 62 59 54 92 60  7 73 27 99 44 | 42 13 62 35 50 17  8  4  2 76 88 61 69 85 46 65 36 79 29 59 81 58 51 77 66
Card  43: 13 23 30 91 59 66 77  1 57 82 | 19 40 54 23 64 70 44 11 34 29  7 91 20 56 93  9 42 28 72 92 46 15 68 95 39
Card  44: 19 20 44 89  5  7 80 55 76 11 | 39 83 13 21 58 80 24 52 47 60 66 92 89 96 88 56 10  5 51 76 36 91 26 98  4
Card  45: 97  7 13 59 20  5  6  3  9 51 |  6 20 64 59 37 31  9 72 57 69 42 15 35 76 24 10 18  3 17 39 97 70 13 34  7
Card  46:  6 95 11 77 79 47 88 21 23 49 | 42 21 95 50  1 11  6 58 66  8 85 88 28 30 23 10 79 16 47 78 90 77 61 80 92
Card  47: 66 32 19 44  9 77 73 97 24 25 | 37 77 82 24 51 73 83 28 19 43 65 55 48 95 75 27 15 25 89 17 40  1 18 49 97
Card  48: 35 40  5 36 23 22 27 85 41 65 | 51 52  7 92 31 33 86 48 21 84 72 91 62 66 53 24 77 99 14 11 69 16 34 47 20
Card  49: 35 61 25 50  8 77  3 65 89 92 | 48 53 80 89 19 96 83 21 38 52 23 60 81 37 73 94 14 41  5 44 31 15 79 86  8
Card  50: 40 15 56 68 38 87 92 70 19 42 | 18  9 78 62 77 33  3 35 52 72 26 39 17 86 85 22 66 34 98 40 61 94 81 32 23
Card  51: 36 67 40 89 50 69 33 64  7 74 |  5 66 78 53 52 34 87 70 60 49 82 25 35 37 28 15 10 45 39 83 71 57 61 95 29
Card  52: 65 75  5  1 74 97 16 59 40 15 | 43 95 57  1 66 41 92 45 70 77 72 68 30 23 42 29 60 48 28 14 32 64 79 90 11
Card  53: 48 86 32 97  6 50 93 95 55 19 | 47 63 64 62 46 33 97 69 61 67 87 98 78 94 74 34 18 21 54 15 60 37 84 30 11
Card  54: 51 25 46 18 84 16  1 19 22  7 | 93 59 75 58 92 12 73 90 82 72  4 49 91 76 26 67 97 95 20  5  9 11 17 21 70
Card  55: 15 52 93 67  6 31  7 53  5 46 | 80 54 36 19 60 12 21 49 88  9  3 84  4 85 50 51 20 79 98 42 87 77 22 75 30
Card  56: 17 12 84 50 20 25 48  7 94  4 |  4 66 18 34 39 27  8 11 15 25 90 57 85 33 88 48 12 53 84 17 20 21 28 52 60
Card  57:  8 97 61 38 88 34 51 45 55  1 | 16 56 62 36  8 50 35 15 27 11 31 32 49 66 83 64 97 99 17 92 91 14  5 82  1
Card  58: 14 23 12 38 87 13 45 66 64 56 | 38 33 51 94  1 64 70 24 31 14  2 75 12 67 85 23 13 74 56 15 42 95 73 96 52
Card  59:  1 99 10 58 91 73 34 76 57  9 | 64 80 94 20 65 12 21 14 93 29 56 75 84 68 55 19 13  4 31 66 85 88  5 95 28
Card  60:  7 41 65  5 73 68 53  4 51 18 | 53 68 18  5 34 50 44 85 41 65  3 39 55 16 75 29 73  7 14 27  4 54 57 82  2
Card  61: 79 84 69 62 35 88 16 97 95 47 | 88 84 35 69 15 59 62 63 34 79 39 12 17 14 10 67  2 90 30 95 82 58  6 43 16
Card  62: 93 80 31 98 88 62 68 47 84 25 | 46 49 28 81 56 33 74 76 69 27 96 53 89 44 20 23 10 94 45 13 87 60 90 21 97
Card  63: 54 91 82  4 42  9 26 11 83 76 | 67 70 36 84 54 25 81 20 52 34 76 96 43 41 92 58 61 26 87 23 29 83 91  9 30
Card  64: 87 93 18 98 56 19 99 95 49 38 | 72 74 16 47 44 39 40 18 76 50  7 73 71 11  3 68 78 14 96 80  6 46 19 77  9
Card  65: 58 53  4 85 70 76 93 31 50 20 |  8 83 68 52 31 46 96 91 86 39 92 88 63 53 20 15 11 29 87 65 93  3 89  1 74
Card  66: 48 27 73 67 97 68 69 22 77 56 | 18 70 38 59 10 82 93 39 48 90 57 43 34 89 98 13 97 69 80  4 41 85 25 86 61
Card  67: 40 18 44 16 15 49 97 77 88  7 | 93 82 90 20 75 68 71 42 53 11  8 41 99 96 59 67 60 14 94  9  5 26 56 80 65
Card  68: 37  5 49 35 97 95 59 80 83 47 | 78 36 32 64 92 77 81 67 69 28 99 40 86  7 93 88 14 15 91 16 89 52 18 30 62
Card  69: 36 90 70 74 55 85 97 19 33 87 | 78 93 86 85 69 43 45 80 56  3 92 76 81 32 29 42  4 94 71 47 26 64 30 67 57
Card  70: 45 18 12 66 47 95 35 86 23 20 | 40  9 50  2 93 55 91 34 44 37 98 99 73  7  6 64 48 88 26  8 53 54 14 90 61
Card  71: 87  8 90 48 28 63 91 74 33 24 | 79 95 72 76 32 88 15 20 97 16 51  7 46  3 61 31 82  4 59 68  8 17 23 86 54
Card  72: 80 56 58 70  4 40 59 23 84 75 | 69 93 58 27 35 39 78 80 20 72 40 75 84 56  4  8 59 24 70 85 23 46  2 14 26
Card  73: 24 56  1 99 35 55 17 16 43 30 | 32 16 55  3 82 99 27 30 61 49 71 24 75  4  1 25 17 41 74 56 31 35 93 43 40
Card  74: 57 29 11 16 53 58  5 34 27 13 | 27 60  6 94 72 53 85 84 29 16 57 39 38 58 34 82 48 63 37 32 11 31 83  5 13
Card  75: 81 35  4 37 10  6 46 79 90 82 | 79 90 27 65 10 47 58 40 94 49 32 28 30 38  4 21 35 83 33 69 14 81 12 76 46
Card  76: 19 84 41 77 53 75 95  8 91 20 | 85 79 55 51 75 26 41 71 73 20 59 18 91 58 19 95 84 72 61 42 77  8 53 87 22
Card  77: 94 34 58 52 28 98 82 22  2 72 |  1 92 34 82 38 12 66  7 55 35  2 48  3 31 22 94 72 85 58 69 16 98 28 52 59
Card  78: 43 47 16 28  1 18 11 20 19 96 | 44 16 76 36 81 52  6 28  2 42 37  7 98 95 46 47 11 94  4 54 97 70 10  9  1
Card  79:  6 35  7 27 44 18 94 34 52 97 | 43 54  6 44 60 77 41 82  7 69 46  9 11 38 94 63 51 86 91 79 27  3 47 31 42
Card  80: 99 38 24 63 71 86 79 67 55 72 | 10 37 22 99 54 55  9 13  6 79  1 71 63 51 44 86 92 26 72 53 38 16 24 27 67
Card  81: 10  6 84 21 83 18 76 57 16 23 | 76 64  8 21 84 56 29 65 54 10 18 93 44 13 87 83 57 79 85 23 16 22  1  6 33
Card  82: 33 61 13  7 41 72  6 65 11 69 | 19 46 24 41 67 62 13 63 54 25 17 49 78 14 60 55 69 72 36 27 86 89 38 94 51
Card  83:  5  4 18 30 87 93 55 12 97  8 | 63 24  8 18 93 12 87  9  5 60 37 44 52  4 64 23 32 66  3 46 35 77 85 75 28
Card  84: 40 77 51 35 61 11 12 33 60 72 | 30 12 16 33 60 77 55 35 92  9 51 29 40 56 26 53 61 46 95  2 50 68 20 14 34
Card  85: 47 58 90 56 28 35 64 57 69 77 | 14 83 77 62 73 78 28 48 44 71 57 87 93 90 47 66 35 65 18 76 99 39  5 81 49
Card  86: 40 74 61 11 26 64 67  2 13 70 | 40 88 14 70 37 21 73 64 32 45 23 33 24 13 60 74 31 27 67  2 65 26 16 61 57
Card  87: 45 94 63 27 82 18 68 69 29 34 | 99 17 88 87 12 30  2 35 55 71 22 77  7 50 97 90 85 79 83 38 91 74 29 28 96
Card  88: 31 12 81 85 87 69 35 21 86  2 | 64 57 41 69 91 80 39 87 71 13 65 23  2 35 40 85 20 76 12 44 21 60 68 50 47
Card  89: 34 48 66 99 75 43  1 64 97 21 | 75 77  3 23 50 20 34 25 96 88 63 99 68  5 24 19  4 45 38  8 79 52 37 16  9
Card  90: 83 39 32 78  4 15 70 98 90 10 | 47 51 83 67 90 69 91 23 66 13 32 55 63  9 54 21 85 93  3 59 28 29 84  2 60
Card  91: 92 64 79 67 34 25 88 98 27 46 | 58 33 31 27 65 70 29 46 57 43 63 87 89 67 80 39 97 37 19 55 45 92 95  7 14
Card  92: 69 77 82 21 11 33 15 65 79 48 | 94 80 19 72 39 63 89 85 74 34 17 92 59 79 54 98 48 96 76 46 84 40 35 93 24
Card  93: 81 78 54 59  4  3 15 96 18 43 | 55 48 22 32  5  4 33  9 37 17 23 97 75 66 85 86 16 88 56 51 26 31 80 20 38
Card  94: 57 25 66 34 55 11 44 86 62 79 |  9 98 94  6 55 97 49 54 83 73 90 84 37 81 95 13 53 10 63 96 82 80 26 33  8
Card  95: 94 98 23 50 71 30 66 52 13 35 | 88 96 79 83 55 53 76 32 63 44 40 92  8 78 20 74 72 85 31 67 97 34 14 19 87
Card  96: 41 39 92 64 83 89 50 57 69 74 | 59 34 61 39 12 24  1 55 98 77 45 72 22 30 23  2 50 53 36 85 75 87  9 14 69
Card  97: 37 96 74  8 53 91 81 57 15 27 | 81 57 50 86 74 27 40  8 15 97 53 64 55 96 37 84 41  6 89 34 91 61 56 72 82
Card  98:  9 73  6 91 46 70 20 39 76 60 | 70 73 57 72 74 35 47 91 46 20 39  6  2 44 60 63 49 27 82 43 12 76 88 54  9
Card  99: 69 56  9 62 73 22  6 71 90 68 | 62 15  9 55 71 18 73 68 86 93 57 69 56 67 77 97 31 58 99 64 60 48 34 90 59
Card 100: 76  2 39 75 21 36 64 44 10 97 |  8 72 34 65 42 84 75 95 73 21 63 51 58 10 27 86  3  5 14 88  2 67 26 46 36
Card 101:  1 83 64 92 20 30 49  3 14 77 | 77  8 57 40 92 65 19 71 20 60 76 30 27  6 84 22 90  3  5  9 95 12  2  1 15
Card 102: 95 20 96 69  2 34 26 17 29 88 | 19 75 60 96 27 46 13 57 45 55  2 69 84 17 71 47  3 25 87 29 30 42 90 16 62
Card 103: 46 61  4 25 84 69 32 47  8 77 | 28 66 19 46 75 22 25 76 99 34 73 71 29 42 69  1 78 97 40 55 82  7 20 14 94
Card 104: 73 76 71 83 72 48 53 25  3 30 | 30 34 95 48 35 32  4 53 17 23 56 19 76 81 47 79  5 87 71 57 49 11 40 85 66
Card 105: 42 35 23 17 82 71 70 49  6 34 | 42  3 52 80 12 67 38 91 70 86 35 27 97 30  6  2 13 84 78 71 36 83 53 17 49
Card 106: 65 91 58 56 23 14 60 28 76 22 | 41 59 72 48 96 63 71 80 57 16 47  6 82 70  3 14 24 44 25 17 55 62 32 53 79
Card 107: 73 21 20  1 65 70 71 75 26 36 | 84 98 96 41 78 50 77  8 57  6 32 47 30 67 53 69 33 24 66 56 68  5 23 91 35
Card 108: 68 89 44 27 20 46 82 90 81 69 | 53  2 24 92 68 80 54 65 36 87  8 39 47 78 57 44 81 77 71 85 55 13 14  5 89
Card 109: 99 87 17 66 48 27 19 23 25 33 | 64 23 36 46 75 94 71 39 74 48 38  1 95 89 86 13 45 58 30 57 63 43 44 97 33
Card 110: 35 33 46 99 66 50 59 78 62 86 | 66 12 90 41 54 19 72 67 29 58 39 73 80 10 23 63 93  5 62 81 46  4 30 16 26
Card 111: 48  4 99  3 13 46 35 28 32 85 | 38 15 64  1 68  8 29 59 86 80 53 83 24 47 57 91 67  5  9 74 44 78 55 21 36
Card 112: 28 10  6 94 76 20 84 97 60 41 | 15 13 99 69 50 29 74 24 58  4 21 57 11 86 32 95 42 62 47 90 38 54 83  9 67
Card 113: 19 44 35 68 47 70 96 16 36 94 | 37 40 42 89  6 50 57 26 75  8 91  9 76 38 17 24 14 83 41 55 34 29 97 99 98
Card 114: 77 33 74 50 52  8 24 61 29 13 | 13 77  8 62 24 60 74 98  1 33 29 58 45 50 63 52 17 61 32 51 75 35 73 38 95
Card 115: 62 87 49 55 12 30 47 17 22 89 | 10 35 62 45 51 20 85 80 66 12 17 89 36 87 30 47 33 72 55 63 49 67 22 95 70
Card 116: 10 12 84 89 21 70 86 62 38 43 | 30 38 84 21 34 86 44 16 14 12 62 43 89 70 96 78 83 10 80 37 19 23  9 91 45
Card 117: 65 51 27 90 58 98  7 47 75 76 | 11 86 31 34  1 85 14 64 74 82 95 15 84 81  2 78 50 83 92 87 63 24 91 33 59
Card 118: 46 74  1 92 51 91 60 84 11 59 | 46 38 98 26 36 90 84 55  1 11 74 91 45 59 14 18 67 51 60 92 49 71 15 79  5
Card 119:  1 86 29  4 43 12  7 20 56 87 | 93 41 34 33 51 97 72 83 26 50 77 99 71 82 23 35 45 30 67 25 79 27 38 81 53
Card 120: 22 55 82 98 13 34 91 75 39 26 | 96 10 47 35 86 19 42 14 70 39 71 75 84 27 40 58 25 87 80 18 67 57 78 26 93
Card 121: 84 35 54 23 87 74  3 57  7 69 | 57 88 82 47 60 38 43 39 23 37 74 84 31 66  1  7 87  3 28 92 54 78 35 14 69
Card 122:  1 16 58 29 45 37 56 60 46 40 | 76 58 33  3 55 19 46  1 96 87 34 29 60 45 37 63 89 22 21 56 67 83 93 40 30
Card 123:  7  6 97 47 48 15 42 20 93  4 |  6 24 44 48 87 59 63 42 23 43 85  7 79 53 26 30 90 29 89 45 97  5 64 15 86
Card 124: 34 77  3 95 14 23 83 48 91 72 | 99 69 74 64 38 12 80 57  1 63 21 67 46 84 26 85 97 94 81 33 52 35 24 47 86
Card 125: 14 59 35 37  9 63 77  6 80 75 | 28 76 68 62 27 93 54 69 34 61  9 71 53  3 82 52  1 14 47 11 98 74  7 92 10
Card 126: 85 92 51 13 29 22 27 91 94 57 | 69 70 72 91 33 27  6  1 35 58 52  9 13 99 22 41 73 49 53 83 89 15 76 10  5
Card 127: 46 51 98 42 61 95 11 16 80 82 | 41 73 80 96 12 75 24 13  2 46 81 10  5 68 91  8 35 93 98  6 17 61 19 72 62
Card 128: 79 45 88 14 72 84 85  5 32 43 | 21 89 60 61 25 69 17 59 32 93 19 68 63 72 84 85 64 23  5 26 18  6 10 38 81
Card 129: 24 57 63 94 78 65 76 75 32 30 | 64 44 22 49  1 90 12 83 14 77 38 47 36 91 28 88 53  4 57 21 13 27 74 18 37
Card 130: 76 56 65 72 71 45 48 79 17 98 |  6 87 41 72 18  3 19 15 70 68 35  2 79 73 24 20 43 80 82 76 27 97 12 45 96
Card 131: 91  9 71 67 13 42 32 25 35 17 | 18 33 76 38 25  9  7 17 28  6 82 72 97 71 83 56 49 77 64 47 52 44 19 43 65
Card 132: 11 54 19 87 15 99 71 64  1 27 | 94 58 59  3 20 84 23 97 21 65  5 45 50 18  4 91 56 26 47 44 12 39 96 92 64
Card 133: 18 69 28  8  3 70 91 45 44 12 | 96 84 93  1 11 79 27 21 22  3 14  4 98 44 92 10  7 89 72 88 95  9 13 78 55
Card 134: 68 26 45 86 13 90 67 58  2 44 | 29 34 83 68 99 21 38 76 14 54 85 89 40 47 23  9 93 79 66 10 52 87 17 53 19
Card 135: 41 75 16 84  5  4 61 40 65 73 | 90 74 48 92 51 66 54 39 21 95 80 94 86 81 67 91 36 79 88  8 87 33 28 31  9
Card 136:  9 43 12 63 35 86 78 77 67 28 | 78 86  9 95 22 28  4 23 12 13 63 59 71 35 85 34 92 38 69 24 43 77 55 67 18
Card 137: 76 83 70 79 84  1 95 22 62 10 | 61 76 97 66 22 89 42 95 99 70 44 14 79 10 51  1 59 47 78 62 55 83 84 88 68
Card 138: 62 68 98 25 34  9  3 19 99 22 | 16 95 12 22 34 71 10 77 45  7 20 81 43 83 37 56 88 99  6 30 80 82 13 69  3
Card 139: 75 17 24  2 25 87 27 83 50 33 | 25 31 33 21 83 46 64 24 56 72 32  9 17 66 27  2 48 90 87 50 55 97 75 96  1
Card 140: 81 98  1 28 10 31 50 15 78 63 | 51 63  1 14 50 57 35 59 33 78 10 98 32 28 15 75 65 22 53 31 81 71 47 44 68
Card 141: 96 75 89  6 77 55 44 29 52 57 | 44 16 93 42 87 31 52 88 39  2 73 66 43 41 37 25 48 89 83 92 61 60 67 18 58
Card 142: 63  9 92 56 15 84 93 57  1 18 | 86 34 44  5 68 20 28  8 89 55 61 12 60 40 64 97 13 36  3 62 54  4 99 19 76
Card 143: 57 92 23 95 63 85 32  1 25 48 |  1 80 69 61 10 92 27 32 25 60 15 13 57 49  8 40 98 97 23 63 48 85 18 95 86
Card 144: 92 96 49 21 53 63 10 97 66 48 | 63 66 96 85 82 23 34 21 71 37 89 43 65 22 10 88 53 40 45 92 27 41  1 97 58
Card 145: 90 15  2  9 34 11 25 48 42  1 | 25 11 49 34 36 40  8 92 59 58 15 43  9 16 90 46 88 57  1 17 48 50 42 14  2
Card 146: 97 23 22 37 27  5 46 80  3 94 | 30 16 81 58 62 74  3 69 41 11 31 71 53 93 35  2 21 28 82 75 65 63 64 79 80
Card 147: 46 58 16 89 43 71 52 90 21 99 | 67 38 69 58 97 12 37 65 35 51 90 75  3 50 40 32 60 88 93 28  5  7 62 99 57
Card 148: 22 20 33 81 37 28 89 52 10 93 | 57 15 45 73 39 30 37  1 60 81 36 46 13 89 21 80 44 82 75  5 85 92  3 38 74
Card 149: 18 90 28 71 17 16  9 82 55 63 | 65 13 10 61 27 71 11 85 84 31 23 75 45 52 76 72 81 50 39 91 41 19 28 32 53
Card 150: 92 27 25 30  1 97 65 75 86 32 | 29 56 41 34  5 54 23 76 52 46  8  3 77 18 68 95 28 73 44 69 79 98 96 61 93
Card 151: 80 13 68 48 89 49 75 78 62 60 | 64 59  3 63  1 51 14 46 22 26 96 90 99 32 23 38 92  4 49 84 58 34 54 77 33
Card 152: 54 57 60 71 27 80 94 72 38 93 |  6 46 54 58 21 57 48 72 51  7 50  8 75 91 71 30 94 24 56 20 27 36 22  9 26
Card 153: 98 84 55 72 17 57 97 25 71 90 | 45 28 75 55 17 31 23 49 80  9 67  6 91 89  2 96 81 84 10 98 25  4 13 27 50
Card 154: 62 83 82 13 53 33 87 66 75 42 | 10 40 32 48 91 69 88 51 41 68 99 72  7 86 25 71 80 17 11  1 79 38 58 93 36
Card 155:  5 93 54 98 87 69 26 43 45 12 | 23 79 28 11 40 34 41 76 80 47 10  5 88 26 64 86 54 55 84 35 17 42 24 72 75
Card 156: 29 98 36 30 70 93 56 10 58 52 | 16 44 53 92  6 51  7 75  5 35 28 87 69 12 27  1 46 97 82 94 90 99 91 41 23
Card 157:  9 28 65 17 75 68 31 87  4 58 | 40 96  6  7 88 45 24 34 72 38 23  8 99 14 53 66 61 16 67 11 80 79 56 83 52
Card 158: 87 80 45 78 39 11 58  4 94 99 |  7 32 17 82 53 51 63  3 22 36 97 27 91 21  1 18 60 52 86 48 15 95 38 14  8
Card 159: 57 24 80 35 13  1 51 95 14 20 | 14 41  8 53 81 32 89 31 37  5 30 44 73 51 70 95 49 57 88 20 15 27  2 58 50
Card 160: 90 99  1 24 64  2  5 72 45 77 | 79 32 46  3 91 29 48 77  2 26 68 99 17 64 22 14 41 92 89 44 83  7 45 74  8
Card 161: 20 90  1 94 51 38  7 52 25 17 | 36 73 17 91 25  1 31 51 35 84 94 20 42 52  4 92  7 60 38 22 69 66 90 10 30
Card 162: 60 82 68 54 36 49 59 55 53 24 | 88 48  3 15 86  9 24 20 80 73 49 97 37 82  2 68 84 39 81 59  4 36 74 89 69
Card 163: 32 85  3 75  5 24 89 83 41 42 | 83 72 21 81 63 58 55 29 23 54 90 73 41 27 75 37 44 32 85 26 89 71 79 94 62
Card 164: 15 69 67 25 71 33 17 56 29 72 | 26 72 71 42 92 96 33 67 43 69 56 45 55 15 31 38 25 98 14 10 17 29 44 27 68
Card 165: 53 33 28 11 61 78 97 43 45 25 | 57 61 45 33  1 95 74 69 18 21 53 28 11 78 97 46 59 38 94 68 43 60 23 25 44
Card 166: 91 52  8 73 42 61 36 21 64 46 | 87 82 46  3 85 95 21 70 62 79 91 40 76 31 51  1 56 39 86 14 25 55 18 30 45
Card 167:  6 92  7 10  5 96  9 19 64 75 | 75 16 64 60 40 91  7  9 21 92 79 29 19 96  5 34 45 23 88 59 54 46 10 26  6
Card 168: 53 37 15  3  9 59 50 83 56  8 | 42 72 50  8 26 66 83 56 47 21 55 70 34 97 96 22 61  2 59 39 43 28 60 64 33
Card 169: 68 58 32 96  1 73 36 54 15 39 | 93 29 73  9 79 87 36 15 62 91 74 10 61 47 69  2 14 30 12 27 42 77 19 57 16
Card 170: 71 64 37 95  3 33 66 10 45  1 | 65 41 18 23  6 33 48 64 37 87 36 80 10 99  1 29 26  4 95 49 63 45 27 71 62
Card 171: 81 26  6 63 39 10 75 15 59 72 | 84 10 48 26 81 46 50 27 37 77 66 52  8  9  6 83 15 80 88  5 47 35 25 63 33
Card 172: 71  8 56 34 57 74 11 79 96 78 | 36 72 31 99 63 54 89  4 44 41 76 66 25 50 92 37  3  7 15 30 86 35 77 19 61
Card 173: 16 34 58 73 30 80 27 81 77 24 | 80 77 29 98 81 17 38 16 97  5 13 34 32 50 49 31 40 39 79 76 95 91 82 85 24
Card 174: 39 16 90  6 73 64 79 95 97 74 | 96 41 15 32 76 14 31 72 12 68  9 91 26 78 47 20 87 44 86 54 21 77 81 60 11
Card 175: 16  6 59 65 30 67 17 63 31 20 | 55  6 79 27 98 91 14 44 29 57 53 78 10 84 97 82 65 56 37 48  4 32  7 94 86
Card 176: 99 51 52 75 17 41 15 10 70 42 | 16 83 76 91 74 42 94 59  8 53 88 13 95 93 29 30 27 40 69 67 51 77 81 35  2
Card 177: 50 51  1 83  4 38 59 76 28 43 | 70 30 23 61 82 35 15 83 49 53  9 46 11 38 72 26 98  8 39 63 55 69 13 22 84
Card 178: 57 35 97 89 84 22 19 26 47 16 | 59 64 40 65 72 32 66 80 92 94 19 21 86 63 73 31 48 96 24 25  6 83 97 34 74
Card 179: 40 23 64 45  8 43 93 10 12 38 | 31 48 28 16 37 65 87 30 41 54 85 80 26  9 25  1 78 69 51 44 36 84 52 79 20
Card 180:  6 65 82 47 78 41 21 48 93 84 | 64 89  8 77 80 17 86 53 69  1 36 16 98 38 54 73 18 97 85 46 12 55 70 37 81
Card 181:  5 41 16 11 58 85 94 40 59 93 | 76 17 30 61  6 74 59 58  5 11 93 19 43 21 82 49 16 41 40 36 13 91 85 14 94
Card 182: 92 16 68 12 61 86 55 67  7 91 | 43 55 12 16 34 67 48 79 98 31 81  7 57 71 49 21  1 97 61 99 92 95 68 39 19
Card 183: 24 49 16 73 56 88  4 11 87 21 | 87 71  7 33 24  4 55 15 73 11  1 62 85 83 78 76 88 81 64 21 35 16 29 86 91
Card 184: 97 78 45 39 22 24 56 81 12 70 | 24 26 15 57 56 52 38 81 35 97 32 92 78 45 19 18 12 37 34  1  9 42 83 51 95
Card 185: 23 65 60  4 58 74 51 71 43 78 | 91 71 18 58 43 22 25  7 92 64  2 57 35 73 29 74 13 75 65 60 61 28 80 88 96
Card 186: 28 77 70 63 90  5  6 36 83 14 | 21 60 16  2 87 50 95 70 49 55  6 73  5 45 83 11 28 57 35 63 54 34 29 65 64
Card 187: 70 94 18 87 60 68 39 91 75 23 | 56 82 74 14 45 93 67  2 22  4 15 25 80 16 10 70 87 75 27 46 88 30 99 52 63
Card 188:  8 86 30 55 16 29 70 89 32 19 | 46 12 64 10 66 89 91 51 28 31  7  2 86 80 82 62 34 49 35 65 87  4 61  9 30
Card 189:  8 81 16 14 32  9 85 94 18 76 | 23 98 39 95  7 15 75 97 50 96 37  9 90 68 14 32 16 45 78 18 99 57 81  6 65
Card 190: 42 43  4 65 45 97 62 51 81 69 |  2 19 88 50  4 43 81 10 37 49 86 54 91 80  1 20 22 55 40 71 14 97 48 70 95
Card 191:  2 28 63 20 32 74 37 65 42 38 |  9 60  2 63 89 59 58 38 57 74 67 54  5  6 73 11 37 23 20 69 27 80 24 21 53
Card 192: 77 24  5 13 18  9 26 56 27 76 | 16 44 23 45 11  2 53 66 38 25 59 91 83 51 74 77 55  7 95 69 65  6  3 62 76
Card 193: 27 37 38  3 70 21 94 42 71  7 | 64 56 39 78 89  9 52 46 97 15 90 69 14 55 31 16  7 72 75 28  4 91 18 32 48
Card 194: 86  2 31 64 69 39 24 61 59 37 | 46 85 40 90 73 92  8 71 24 97 35 70 19 57 14 23 32 15 98 77 56 82 26  6 20
Card 195: 82 32 90 59 51  6 27 24 36 98 | 74 79 95 91 14 87 39 57  1 20 37 93 68  4 54 66 86 35 36 28 38 49 65 98 67
Card 196: 54 71 23 38 79 55 78 67 44 10 | 71 17 85 93 55 72 68 14  8 11 75 86 52 41 47 61 29 53  3 59 30 21 76 92 32
Card 197:  7 65 66 60 52 23 15 27 32  3 | 59  4 79 97 91 41 83 36 22 89 19 38 96 81  8 29 49 86 46 12 25  6 24 16 78
Card 198: 89 99 29 80 68 39 38 10  2 63 | 88  8 92 81 23 54  1 12 45 96 67 86 37 98 47 34 71  4 58  3 27 41 75 93 66"

module Day05 =
    let example1 = "seeds: 79 14 55 13

seed-to-soil map:
50 98 2
52 50 48

soil-to-fertilizer map:
0 15 37
37 52 2
39 0 15

fertilizer-to-water map:
49 53 8
0 11 42
42 0 7
57 7 4

water-to-light map:
88 18 7
18 25 70

light-to-temperature map:
45 77 23
81 45 19
68 64 13

temperature-to-humidity map:
0 69 1
1 0 69

humidity-to-location map:
60 56 37
56 93 4"
    let p1 = "seeds: 222541566 218404460 670428364 432472902 2728902838 12147727 3962570697 52031641 2849288350 113747257 3648852659 73423293 4036058422 190602154 1931540843 584314999 3344622241 180428346 1301166628 310966761

seed-to-soil map:
357888202 777841571 45089383
1091769591 2222785614 212172358
747211456 668867483 108974088
635547523 229171508 111663933
1573402842 2067459960 102412403
4289698662 1148443045 5268634
2395735068 1322252554 161006801
0 205577967 4476015
57955189 635249899 15743396
402977585 0 26133741
464695488 412326242 24494890
2966156314 1301354919 3630744
42819069 472405294 15136120
3261136238 2193516168 29269446
2394617262 1304985663 1117806
3573311427 1725292988 265415981
3184385247 1990708969 76750991
36407558 487541414 6411511
178443976 26133741 179444226
4233901482 2444128986 55797180
2556741869 2169872363 23643805
429111326 436821132 35584162
4476015 622435882 12814017
2830010004 4158820986 136146310
1315195976 890236179 258206866
17290032 210053982 19117526
2969787058 3404926809 66954949
106953175 340835441 71490801
3307388168 3846327739 265923259
2580385674 3488864242 249624330
3036742007 1153711679 147643240
3290405684 3471881758 16982484
4187331494 4112250998 46569988
2378468177 1306103469 16149085
1308440551 2936378300 6755425
73698585 822930954 33254590
489190378 493952925 128482957
1675815245 1483259355 242033633
3849072207 2598119013 338259287
1917848878 2944307510 460619299
1303941949 885737577 4498602
3847898422 2943133725 1173785
617673335 650993295 17874188
993576744 2499926166 98192847
3838727408 2434957972 9171014
885737577 3738488572 107839167

soil-to-fertilizer map:
146677673 622659563 93167301
1157991666 1089969349 162939558
3393833863 2765693883 993201
1089969349 2528480087 47120899
1536155605 1455175707 97002831
77735382 829301434 68942291
519819619 496909514 125750049
1633158436 2638516375 127177508
2914682387 1777568650 8769904
1907493268 2936307342 209538906
1523198024 2370144872 12957581
398047045 375136940 121772574
3155987938 1552178538 225390112
2722437809 1786338554 7281125
2405956502 1793619679 316481307
4079025823 3374787635 121920527
1020706608 898243725 11125486
1320931224 1252908907 202266800
4200946350 4161901201 91091718
2872708010 4252992919 23854892
2896562902 4276847811 18119485
2923452291 2766687084 169620258
1760335944 2261396563 6024603
362307857 715826864 35739188
4292038068 2525550859 2929228
2345973561 2310161931 59982941
3426288597 3496708162 124839972
2768316300 2383102453 51488089
2729718934 2455491960 38597366
1137090248 2434590542 20901418
2819804389 2110100986 52903621
3394827064 2494089326 31461533
1809101312 2163004607 98391956
3551128569 3621548134 527897254
1766360547 2267421166 42740765
2117032174 3145846248 228941387
645569668 0 375136940
0 751566052 77735382
239844974 925431556 122462883
3093072549 2575600986 62915389
1031832094 909369211 16062345
3381378050 4149445388 12455813

fertilizer-to-water map:
1853863567 1354319094 57762399
1963297596 2892133710 74523026
351355449 2825239457 1556531
4263216859 3376413885 31750437
2555584073 3055976839 118124436
2730998967 1343408443 10910651
1638376751 979599391 153825342
978844708 811605824 82508702
1911625966 894114526 6715081
3367668240 3408164322 203176531
2729654714 3174101275 1344253
3200258520 795809557 15796267
1595497633 1782591008 42879118
2683440491 1412081493 46214223
1958950306 101242881 4347290
2831229721 242278649 124658639
1792202093 734148083 61661474
2741909618 2966656736 89320103
1918341047 3175445528 40609259
2955888360 1825470126 7069388
3594735667 3635231749 181844678
2673708509 412658344 9731982
2962957748 1832539514 237300772
530398473 105590171 136688478
1177133692 366937288 45721056
27883870 2489305043 153451249
352911980 2711533741 113705716
3570844771 3611340853 23890896
466617696 900829607 30422191
0 2461421173 27883870
3776580345 3360472089 15941796
4207783288 3817076427 55433571
2429401509 1249205015 60844842
181335119 2642756292 68777449
1061353410 1133424733 115780282
667086951 422390326 311757757
2490246351 2826795988 65337722
1222854748 931251798 48347593
1271202341 1458295716 324295292
3360472089 4287771145 7196151
497039887 1310049857 33358586
2037820622 2069840286 391580887
250112568 0 101242881
3792522141 3872509998 415261147

water-to-light map:
3392354816 2147745556 27501466
1878871951 1725889381 75406426
173441126 161378219 150090654
1018905669 635099142 165518615
4087062942 1662057640 30823678
353004829 1119237890 172394750
1845863888 1692881318 33008063
153206340 867143452 20234786
2604702405 4037570714 169107986
1617110925 3533554525 169325605
2559755690 1617110925 44946715
600097153 912061633 124651296
3946007322 3319554557 141055620
2465332301 3460610177 72944348
724748449 340941922 294157220
3044149982 2175247022 348204834
2773810391 2633005641 270339591
525399579 153206340 8171879
2139921020 3702880130 325411281
3419856282 1978376483 109941715
1954278377 2523451856 88074744
2538276649 2611526600 21479041
4117886620 1801295807 177080676
2051632424 4206678700 88288596
2042353121 4028291411 9279303
3529797997 2903345232 416209325
1786436530 2088318198 59427358
533571458 800617757 66525695
1184424284 1036712929 82524961
1266949245 887378238 24683395
323531780 311468873 29473049

light-to-temperature map:
2119656026 2694441768 51718564
582739623 515860164 331142829
3188466529 3433161801 686443431
1208858214 1852905471 223488011
2984018793 2746160332 20792175
114072893 923500840 335770555
1078092281 1568663312 55313164
1528379045 847002993 76497847
3159539374 3404234646 28927155
1604876892 44343574 471516590
3874909960 2119656026 229635679
913882452 1404453483 164209829
449843448 1720009296 132896175
3004810968 2539713362 154728406
1432346225 1623976476 96032820
2171374590 4119605232 175362064
2827425140 3247640993 156593653
1177749019 1259271395 31109195
2346736654 2766952507 480688486
1133405445 0 44343574
0 1290380590 114072893
4104545639 2349291705 190421657

temperature-to-humidity map:
4032879828 4294798436 168860
4033048688 927598400 261918608
0 101834652 315424112
3415479218 1417189709 517560635
3933039853 4175022329 99839975
2470365900 2513768139 498846371
2059440409 4274862304 19936132
2969212271 2295173893 218594246
315424112 417258764 36139086
351563198 0 101834652
927598400 1934750344 360423549
3187806517 1189517008 66595582
3254402099 1256112590 161077119
2079376541 3784032970 390989359
1288021949 3012614510 771418460

humidity-to-location map:
1627636687 2047220773 460084702
2744823277 560934787 184170906
3485120052 3437939311 342343442
3959782982 3213426504 221968093
1599327759 745105693 28308928
2311378749 773414621 172869650
4292422582 3435394597 2544714
4181751075 3780282753 110671507
2484248399 1371539463 260574878
944796451 1771589193 23241552
2985880462 4036578393 258388903
896379083 2507305475 48417368
2298631675 0 12747074
237282755 12747074 435619394
812377001 1310308951 61230512
1486759440 448366468 112568319
3827463494 2985880462 132319488
3389893498 3118199950 95226554
0 1073026196 237282755
672902149 1632114341 139474852
3244269365 3890954260 145624133
1103441152 2555722843 279347933
2181644796 1794830745 116986879
873607513 1050254626 22771570
968038003 1911817624 135403149
2087721389 2835070776 93923407
1382789085 946284271 103970355"
    
    let example2 = ""
    let p2 = ""
    
    
module Day06 =
    let example1 = "Time:      7  15   30
Distance:  9  40  200"
    let p1 = "Time:        48     87     69     81
Distance:   255   1288   1117   1623"
    
    let example2 = ""
    let p2 = ""

module Day07 =
    let example1 = "32T3K 765
T55J5 684
KK677 28
KTJJT 220
QQQJA 483"
    let p1 = "3A399 27
46645 201
8A9K4 40
88333 578
55353 817
99Q99 146
553J5 45
AAQ2A 547
TKQ2K 120
57592 534
7Q49K 229
JK949 744
688T6 657
98888 392
4K638 337
J8888 96
Q92KJ 778
48J96 374
955J6 307
62TT6 896
934AK 776
44654 720
AJAAA 568
K6J5Q 162
T29A4 342
46342 467
22227 694
TQ4TT 468
88688 728
88999 183
Q7T6J 463
92T9J 884
KAQQQ 299
3275Q 913
Q5535 82
93A4J 48
J9888 552
2QTQ4 846
44554 795
JJJJJ 348
TT477 733
58883 460
77377 317
357J3 725
T9J4Q 346
88228 953
Q4858 982
5T5TT 405
TTKTT 322
QKKKK 197
A5Q5A 956
2T22A 962
TQJTT 734
84TAK 360
T39Q7 375
QJJTT 925
62236 928
474T7 302
37KK3 411
7J474 325
55K5J 850
TTJ2T 780
Q5259 127
93K6J 191
T996T 333
99929 193
9JKK3 115
2A647 409
3AAAA 966
85K58 464
22893 607
QJQJJ 471
59T9T 690
K8484 167
TKKK2 526
44243 273
KQ888 792
6J3K3 216
44446 169
325QK 461
47T2T 990
7J78J 410
A7JJA 562
2253J 598
QK385 103
65556 721
TTQQ9 943
Q4Q44 176
JJ8JJ 539
J799A 237
994QK 510
78996 458
AK663 145
QAA78 767
2Q662 797
A696A 572
QA82J 975
T7KJQ 126
722JT 416
2J222 57
6Q937 719
AKJ58 39
QQJQJ 582
AJATT 187
Q484A 384
T9T87 272
5T7T3 699
44K44 812
44228 505
983Q5 444
55355 74
J2JJ2 353
TJ2T2 883
Q96J9 708
7KKKK 447
557J5 280
AT4T7 407
AQ9JJ 73
K6K2J 597
K7Q7K 394
QQ4JQ 635
2JK35 269
94934 78
99K9K 235
K7K27 91
QQQTQ 588
773A3 702
26232 110
AA44A 909
33Q3Q 313
83335 518
7AA84 287
484T4 662
7JKK7 29
9J999 38
Q58T9 17
29JQ7 355
772TT 783
JK66K 473
TKKTK 433
52T56 318
8Q734 628
K43J7 226
AA569 77
J4A54 988
84J4J 500
97TQ9 240
4K554 305
27999 847
8QQ83 85
57638 521
K5KK9 974
97K3Q 234
T88TT 747
22JAT 71
TJ337 983
TA3QK 555
87686 372
5KKKK 828
QK868 168
99J59 813
AA28A 875
47382 837
27K77 46
2KKKJ 10
22292 448
K4KKK 774
A3A9K 428
99222 184
Q9Q4Q 336
QQQQ4 631
KJQTT 249
T3K46 644
929J9 165
2KK22 527
AKAA5 358
Q2224 369
T273J 265
282JJ 28
Q488Q 513
38J88 633
3T3T3 283
88855 863
6J39Q 75
J44K4 543
27272 731
5576K 880
JTTKT 400
55J55 750
2QQ99 919
4668Q 55
9A999 5
JK294 536
TJ937 692
KKKKJ 86
647J4 625
94227 308
6AJ5J 841
99AA5 224
685A7 24
TAAKK 112
286K4 762
J5Q8A 232
33323 494
2A6Q3 495
JQKT2 37
AAAQA 978
K34KJ 703
7J74T 994
2J828 723
5T3T4 535
48658 140
J99JJ 954
TT826 678
KK3J8 840
TTT6J 439
7QQ6T 589
58585 963
TTT2A 190
JQT52 261
66J76 682
925KQ 951
T3223 141
J78QJ 785
QQ277 567
4K6TK 349
K888K 309
2J664 713
75657 218
96J96 614
23727 610
89477 134
T8456 957
7K47A 230
A3AA3 107
24KK3 538
65J48 119
JA98K 647
KKT6T 935
A4AAK 248
K7779 225
J5574 438
Q6QQQ 697
39QTT 469
K9J62 282
2K242 971
QJJK6 41
49J77 122
393KK 403
Q222Q 789
88Q8Q 587
4Q8AA 247
63396 211
KKJJK 111
JQ4K7 918
79775 506
T5T55 532
8J558 125
2QAK8 641
59548 537
345K6 106
Q42K7 695
88KKK 934
4J8J6 519
644JJ 612
J796K 368
3J633 621
66T3A 707
7Q3K3 768
A258Q 866
9463A 820
58555 843
36T4J 914
96K4A 8
Q34J7 654
88QAA 651
AA5J5 58
73333 740
JTT9T 609
3QQQQ 871
33957 442
84888 446
83Q83 742
K2K3K 243
JKJ94 377
K62K2 385
6QJ87 704
847J7 61
87J89 594
77JQQ 54
56KA5 56
AAQQ9 233
A8AKT 236
37KKA 711
J8279 244
J2Q23 987
666J6 939
3JJ77 16
QQQKQ 104
96QQ4 398
J38JA 585
8QKQ8 899
4TJK2 806
66686 421
5T4T5 889
K4944 206
65KQ6 443
36366 59
TJT36 996
JAA3A 367
4985K 395
999QQ 926
832J6 821
88K7K 890
J7777 902
35855 991
332KK 710
76AT7 365
533K3 65
AAAA9 864
45TT4 758
TJJTT 418
282TT 178
T536K 474
J5J3A 259
Q3QAA 796
222JJ 793
Q4666 64
93TT9 219
69555 26
449JA 238
64935 754
7K24K 622
Q7999 932
55474 288
J5QQ5 929
J794A 669
44K4K 634
8T6A5 808
77252 7
JA8Q4 70
3JTKJ 181
34433 845
A3444 548
84889 262
4A9TQ 32
85A88 189
73883 321
7T776 274
K62QJ 138
TQ7TQ 80
6A7AA 786
TA379 872
25T33 584
73747 965
Q28KQ 1000
2A222 144
94993 345
A9238 172
8468T 630
99646 649
69KK7 210
QK5K6 457
6QJ6Q 12
36339 643
88A4J 63
K57JK 549
77888 382
T4J56 198
AQQA7 481
644K2 492
T46AA 397
5J3TJ 861
J7J79 20
3333A 42
QQ555 892
3AJT5 36
J4K8A 208
874TJ 376
J999J 215
A8AK3 782
84444 504
TT2TT 905
8746J 752
AA5A5 449
A75JT 204
55595 379
KK665 775
22244 364
22283 152
AA25A 149
AA3KA 826
K399K 981
93384 97
46494 347
3TQJ4 19
KKK7Q 158
776J2 267
7A77J 486
A4454 9
6857K 858
3J3TT 435
339J3 99
JAQJQ 105
82367 571
3QQ3Q 556
QJTJQ 599
696T3 334
JKA22 829
J6686 576
92Q4J 217
8288K 289
7JJKA 904
33383 613
J339T 315
88483 503
9995A 319
8K92J 483
TJ244 266
KJ957 574
74A44 148
77KK7 591
QJQ75 898
88J8J 885
92K54 137
64647 579
66226 560
JJ488 839
43J42 673
3K3K3 849
99977 108
JTT47 113
2634T 68
TJQT5 838
77Q77 763
2AAKA 972
78QJ7 257
6J923 544
2J2KK 164
259K3 882
88K78 602
4786Q 924
42444 650
8536T 52
AQTT5 546
3333J 581
3K984 501
A8832 685
34J55 133
62985 700
4353J 386
44454 23
77772 116
65665 679
KKK7J 124
A7578 749
5AQ54 396
7KK8Q 807
7T7T8 911
73JJT 157
98A99 753
446J4 477
4T43A 205
TT999 798
88885 915
9Q64J 659
7767K 357
A5329 559
85KKK 739
9969J 714
QJQQ9 427
KT4KT 15
5T5J5 638
J74AJ 736
56666 524
5T558 930
2233A 350
7AA4A 502
QAAA7 595
7737T 151
JQ4Q6 677
67864 691
2KK3Q 117
8272K 414
75J57 159
443J4 479
55KK5 207
K88TK 910
3Q9J9 332
JAJAJ 338
69369 339
82KJ6 335
K39KK 773
99492 422
3T663 270
T5958 328
9A45K 715
23593 922
JKK37 765
KJKT7 769
Q74QQ 173
6232T 729
227Q2 436
7AQK4 430
8Q4JQ 509
J8248 297
TT779 306
A3K34 852
97228 832
TJTJ7 300
A8898 553
82TJQ 4
92738 131
AAAJJ 440
TT972 51
69AQK 646
QQ7QJ 705
4JK85 718
7Q63T 220
44A24 737
7QAQT 292
66699 979
3Q974 329
TTT6T 648
85288 686
989QT 278
7Q6AK 964
66466 251
99744 271
TTQTQ 163
3433T 177
K2333 142
QQ4Q4 938
9Q6Q9 787
47T63 831
2J56T 493
94494 72
25552 869
936K2 390
A8AA8 605
3TT35 727
2A24T 129
94999 323
64A2J 824
K7676 756
QQQQ7 18
882J8 748
2J77A 611
222TJ 959
T6266 722
823J3 627
8T569 771
58KK3 331
59329 209
K9K87 6
82484 150
9444A 98
TQ445 487
J999K 462
JT4TT 246
5A455 640
67KAJ 687
6A83J 570
36J6J 90
6AK6A 573
88K88 781
5A3K4 931
22J27 499
44T44 948
K44TT 213
554K5 927
6528A 202
999JT 667
7J256 401
A2272 937
2QJ3Q 900
63736 973
32522 933
T666T 664
88992 706
JK267 603
QQ99Q 316
AKKKK 507
8688J 862
48858 970
66229 378
K495Q 14
79539 761
A33K3 491
QAQQQ 417
T92JA 620
AQQ8J 475
64A4K 295
4A824 231
8KTK3 453
229K5 969
Q3Q53 284
Q6K34 35
QJQ8Q 402
39922 69
J9TK8 920
4Q3K8 881
454AA 999
556Q9 531
22K22 496
6AA39 291
792K3 810
TQQTJ 660
J677K 764
QTTTT 998
22223 529
3333Q 842
2AAJA 755
J64K6 466
TJA4T 693
J2622 441
42442 566
754K8 459
35826 976
4743T 676
693TA 672
58887 391
K4899 434
TTTT3 88
356T2 894
77784 212
3373T 399
78777 895
Q97TT 950
88T8T 760
J48K2 663
J3A3A 424
555T5 25
37373 389
J6J46 174
4TAKT 171
6TKQ7 624
5A775 3
TT3T3 326
28558 489
TJ38T 936
6AK66 254
44664 223
77QQ7 87
Q2829 675
5TTJ5 995
T2T9J 454
7878A 264
83843 84
JKKK3 802
98436 192
3AA22 940
555A5 136
J333J 221
97KJ3 636
JK582 801
5Q82K 515
25J2T 180
34234 746
JQ4K9 255
224J2 668
68999 639
7T77T 886
6A92Q 629
JJ55J 161
99599 429
6JQ3Q 43
4699A 361
75AT2 917
T9TTT 514
55A95 551
J6A96 47
AAJAT 617
64669 222
QQ9QQ 626
44J44 688
Q3355 92
J8J8J 835
T4382 363
J359A 296
49Q49 653
AAT66 908
44T72 961
AKA44 901
49994 290
A344A 732
JJQJK 777
J8JQ8 819
A89T9 565
72A72 868
K7867 153
K6663 179
K76K7 854
9T265 419
9K7K9 865
7797J 426
25KKJ 670
75575 11
75955 431
TK99Q 684
KJ273 76
57525 285
J3AAJ 263
Q7QQT 590
Q77AQ 879
33626 423
AAA77 139
76584 730
2K9QQ 356
22225 857
44KKK 656
954K6 814
79TA5 135
KQKKJ 62
5QQ88 311
77K87 452
ATTTT 370
J64QA 815
29399 985
2T792 351
5782A 324
57T74 294
TQJ53 182
42222 645
K4Q92 320
77A7K 583
AA999 977
T77TK 279
5T586 799
6K67Q 301
6J8J2 67
99JJT 344
A395K 540
35AAA 779
68QT3 557
45T3K 175
587Q2 717
8QK39 616
73574 550
T8A36 986
333AA 800
2KKKK 393
9Q6T9 250
A88A8 203
J4J44 194
848J8 281
5A49Q 44
8J88A 406
8JTTT 877
77767 955
22K46 199
6A9AT 387
T5Q7K 482
52999 577
Q6685 632
TQJQQ 525
77477 712
K5656 601
KKA7A 380
AA66A 373
83ATT 942
3JJ9K 508
89988 791
TQ746 757
8J99T 743
KKK22 642
J44K2 980
K9KAA 830
9AAA9 260
558J5 870
KQKK2 352
JT4T4 498
K647T 967
9K364 569
44833 844
T2922 856
T3463 276
2TTT2 60
Q542A 724
7J724 992
KT92K 286
8K388 888
4394Q 600
Q747Q 818
433J4 945
66J45 381
55J59 912
9A5A5 606
3K98A 195
9J49A 523
2642J 944
9K8Q7 89
3J335 241
J639J 564
63J79 383
5Q4J7 455
777T7 674
6793A 166
KK9KK 277
4TA95 873
KQJA9 81
2T777 834
4K44A 109
93572 312
33537 258
756KQ 304
4J449 770
27JKQ 412
KK8KK 596
J9666 415
34943 93
85J6K 404
J6QJ5 118
4A452 343
7548A 327
6644J 472
T3A7Q 887
T3J3J 661
QQ79Q 516
73JAT 592
2QQQJ 413
QJ523 541
82878 488
722T2 256
4KA4K 923
96T99 490
3AKK6 696
6J6JJ 147
922JA 593
J88K6 371
52245 867
84664 637
T2T22 853
T26A9 952
8686J 253
J6AA3 53
6A65A 701
JAJTA 745
3843A 859
39399 114
J28Q3 121
98KT4 13
TTQTA 772
39KTT 683
53J53 298
47434 671
4J33Q 542
9Q9J9 214
TTTT8 984
A45K7 891
K488K 916
AJ636 997
7QQQ7 563
68877 359
655QQ 790
3AA4A 855
T4TTT 958
9246Q 666
85K48 485
AJ283 484
54J5K 21
KK9K9 2
Q69Q3 22
J4555 809
J322J 921
752J5 530
6K43K 480
6AAAA 836
92A29 803
66888 665
25529 83
2AJ22 558
89999 476
Q8777 155
7787J 388
Q2765 123
TJ2TK 833
55AA5 903
22662 33
7QQQ2 575
7J77J 561
72878 874
QQJQQ 154
T693Q 520
5TT3T 31
JQQ44 340
2JJ2Q 804
J24T2 784
K7J3J 811
7KTJT 156
8848Q 228
44944 947
K5426 893
A55A8 655
AAKK8 619
75555 751
Q2222 816
TJJ9J 906
J4224 314
26A7K 738
97J54 1
7KK7K 794
3KKK5 451
955K9 827
Q9QA2 293
J2A28 200
J2K77 341
83888 196
J97K7 823
75TJ9 186
J7638 49
46K36 128
92JJJ 735
29A87 185
89449 100
3KAJK 445
QQ343 586
8466J 79
T3T37 362
252T4 528
A3A5J 242
6QQQT 822
7AJA6 615
K9625 268
KK3AK 517
5Q5Q8 658
T87K3 618
57629 788
A7A7Q 160
889TQ 741
TT59T 425
Q2KQJ 30
A4K3K 143
6664K 456
KK4J4 726
TTTTJ 437
QT824 132
J555J 478
75KK9 354
94979 34
K846J 432
QQ887 130
TT97T 170
66TQ6 878
57K78 993
88JK8 608
AK5Q3 907
AATAA 989
QJQ8J 533
8QQQQ 522
5JQ49 102
T3T65 188
66446 759
3Q695 275
AAQTA 689
43J33 623
TJ444 968
Q28Q2 330
J777T 450
QT3JQ 420
T327A 897
QKQKK 580
92KA7 946
7A93K 497
6KAAA 239
889TA 50
K5KK5 511
J443J 303
TTT7J 310
QAK8A 252
J8658 805
896K6 680
88482 876
69QJQ 408
4A3J2 941
8868T 94
7766Q 851
62J25 825
3TT9T 716
Q5KKK 860
K7488 95
33343 766
JT888 366
J8885 681
J66J6 554
JA65K 604
QTJ44 848
583QJ 465
89Q79 66
27477 512
JTK33 101
TTTQK 652
A4ATA 545
J3A33 470
34QAK 245
6Q668 698
66777 709
5K557 227
43666 949
66A6A 960"
    
    let example2 = ""
    let p2 = ""    

module Day08 =
    let example1 = "08"
    let p1 = ""
    
    let example2 = "08"
    let p2 = ""
    
module DayXX =
    let example1 = ""
    let p1 = ""
    
    let example2 = ""
    let p2 = ""