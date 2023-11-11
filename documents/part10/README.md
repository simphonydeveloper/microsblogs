## The relationship between CheckGuid and CheckSeq

**The first nine digits of the checkguid string are checkseq**



I tested the data and created some orders through TSAPI, and obtained their checkseq.

```tex
tsapi checkseq
303784080
database checks guid
e3ef0dcf37c840809c46d52285ea3b0100000121

tsapi checkseq
862233774
database checks guid
8fdb6223377c48a999ac9f21684ef5a700000121

tsapi checkseq
232321459
database checks guid
cfc2323fc21d4c59822ba8e436bd1dec00000121
```

I think this is possible. Because I haven't found any place to store checkseq in the database, it must exist somewhere.