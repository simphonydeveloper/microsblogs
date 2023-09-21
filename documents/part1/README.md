## Get project reference entry from the database

Sometimes we will include some information in the citation entry, such as member ID and third-party payment ID. Then, in other applications, I want to read the reference information for business processing.

### Example

I am entering a test information for Cash payment.

![image-20230915165333271](./images/image-20230915165333271.png)

After completing the transaction, go to the database to query the reference information.

```sql
-- get plainData
select * from SECURE_DETAIL where CheckDetailID=6012700003

```



![image-20230915170003507](./images/image-20230915170003507.png)



Under normal circumstances, it is actually encrypted and needs to be set up in **EMC** to see the text information.



![image-20230915170226549](./images/image-20230915170226549.png)



Options  enable #45

![image-20230915170334288](./images/image-20230915170334288.png)



Thank you, **Darshanp**. This is the inspiration he gave me.