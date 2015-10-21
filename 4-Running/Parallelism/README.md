#Parallelism

The programs inside this folder are meant to test parallelism and its impact in program performance.

###Test results:

-----------------------------

**Test 1**

![First test](/4-Running/Parallelism/1-First-Test-result-before-Tasks.png)

 *Test before Parallelism* 

Application ran in 4291 ms, although the range observed was around 200 +- that.

The processor was relatively untouched even while processing the graph.

-----------------------------

**Test 2**

![Second Test](/4-Running/Parallelism/2-Second-test-with-two-tasks.jpg)

 *Test with two tasks* 

Application ran in 2970 ms, not a very marked improvement. Variance range observed was +- 200.

Processor starts getting slightly more taxed during this test.

Method for calling was divided in two manually asigned parallelism tasks.

-----------------------------

**Test 3**

![Third Test](/4-Running/Parallelism/3-Third-Test-with-four-tasks.png)

 *Test with four tasks* 

Application ran in 1816 ms, with +- 100 ms variance observed.

Processor visibly spikes on the first runtime, other runtimes take processors up to around 60%.

Application speed at this point is more than double of the non-pararellized version of the program.

-----------------------------

**Test 4**

![Fourth Test](/4-Running/Parallelism/4-Fourth-test-with-for-loop-task.jpg)

 *Test with Parallel For Loop* 

Application ran in 892 ms, with +- 40 ms variance observed.

At this point our application is 481% faster than it was before we used parallelism.

Processor spikes to near 100% usage when this application generates a graph.

-----------------------------

**Test 5**

![Fifth Test](/4-Running/Parallelism/5-Fifth-test-a-canceled-graph.jpg)

 *Not really part of the tests* 

Added method to cancel parallel processing. Variance in color ocurrs because a new graph has been partially generated when the cancel is triggered. 

Not part of the tests, just thought this looked cool and thought I'd share.
