# SimphonyScreen

## Guide

A tool similar to Simphony OCBs.

[Texas Digital Order Confirmation Board (OCB) (oracle.com)](https://docs.oracle.com/en/industries/food-beverage/simphony/19.6/simcg/c_order_confirmation_board.htm)

But SimphonyScreen is different. SimphonyScreen is mainly suitable for displaying some advertisements to customers while placing orders.

![image-20240516112227367](./images/guide.png)

## Plan

✅Completed   ⬜Developing

✅Open check synchronization check

✅Menuitem and condiments synchronization  check

✅Close Check synchronization  check

✅Save Check(Service Total) synchronization  check

✅Check Information(EmployeeName,CheckNumber,Total Due,Tax,Other,Service,Subtotal......)

✅Service Charge

✅Discount

✅Tax

✅Combo

✅Photo advertising(rotating)

✅Video advertising

⬜Text advertising (colorful)

⬜Version compatibility (2.9, 18, 19)



## Use

The installation files are in the same directory.

After successful installation, the page will display **SimphonyExtension**, which contains DLL content.It needs to be configured in EMC.



In the **settings**, you can choose **images** or **videos** to display advertisements.

Video:The video will be played in a loop.
Image:The image will be played according to the time interval (of course, one image will not)



Then you need to win+p and select Extend.

The Open button will open the advertising page, The Close button can close it.

[Feedback](https://github.com/simphonydeveloper/microsblogs/discussions/2)

## Ultimate Plan

Web management backend, online management of all Simphony Screen clients.Version control, advertising content control, etc