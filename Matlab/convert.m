#x axis
n = linspace(1000,100000, 100);
#Getting the observation values from C#.
quick = dlmread('quick.txt', '', 0,0);
quickTime = dlmread('quickTime.txt', '', 0,0);
heap = dlmread('heap.txt', '', 0,0);
heapTime = dlmread('heapTime.txt', '', 0,0);
merge = dlmread('merge.txt', '', 0,0);
mergeTime = dlmread('mergeTime.txt', '', 0,0);
insertion = dlmread('insertion.txt', '', 0,0);
insertionTime = dlmread('insertionTime.txt', '', 0,0);
counting = dlmread('counting.txt');
countingTime = dlmread('countingTime.txt', ' ', 0,0);


#Graphs
#Insertion
#1)Theoretical Time Complexities
subplot(1,2,1);
hold on
plot(n,n.*(n-1)/2,'g')
plot(n,(n.^2)/4,'r')
plot(n,n-1,'b')
title('Insertion Sort - Complexities - C(n)');
xlabel('n Values');
ylabel('Complexity Values');
legend('Worst','Average','Best',1);
hold off
subplot(1,2,2);
hold on
plot(n,n.^2,'g')
plot(n,n.^2,'r')
plot(n,n,'b')
title('Insertion Sort - Time Complexities - T(n)');
xlabel('n values');
ylabel('Time Complexity Values');
legend('Worst','Average','Best',1);
hold off
#2)Empiric Basic Ops
plot(n,transpose(insertion),'r')
title('Insertion Sort - Empiric Data');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Basic Op',1);
#3)Empiric-Theoretical Basic Ops
hold on
plot(n,n.*(n-1)/2,'g')
plot(n,(n.^2)/4,'k*')
plot(n,n-1,'b')
plot(n,transpose(insertion),'r')
title('Insertion Sort - Empiric-Theoretical Data Comparison');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Worst','Average','Best','Observed Ops',1);
hold off
#4)Time
plot(n,transpose(insertionTime),'r')
title('Insertion Sort - Empiric Time Data');
xlabel('Input Size');
ylabel('Time(ms)');
legend('Miliseconds',1);
#5) Time-Basic Op
subplot(1,2,1);
plot(n,transpose(insertion),'r')
title('Insertion Sort - Empiric Basic Op Data');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Basic Op',1);
subplot(1,2,2);
plot(n,transpose(insertionTime),'r')
title('Insertion Sort - Empiric Time Data');
xlabel('Input Size');
ylabel('Time(ms)');
legend('Miliseconds',1);

#Merge
#1)Theoretical Time Complexities
subplot(1,2,1);
hold on
plot(n,n.* log2(n) - n + 1,'g')
title('Mergesort - Complexities - C(n)');
xlabel('n Values');
ylabel('Complexity Values');
legend('Worst',1);
hold off
subplot(1,2,2);
hold on
plot(n,n.*log(n),'g')
plot(n,n.*log(n),'k')
plot(n,n.*log(n),'b')
title('Mergesort - Time Complexities - T(n)');
xlabel('n values');
ylabel('Time Complexity Values');
legend('Worst','Average','Best',1);
hold off
#2)Empiric Basic Ops
plot(n,transpose(merge),'r')
title('Mergesort - Empiric Data');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Basic Op',1);
#3)Empiric-Theoretical Basic Ops
hold on
plot(n,n.* log2(n) - n + 1,'g')
plot(n,transpose(merge),'r')
title('Mergesort - Empiric-Theoretical Data Comparison');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Worst','Observed Ops',1);
hold off
#4)Time
plot(n,transpose(mergeTime),'r')
title('Mergesort - Empiric Time Data');
xlabel('Input Size');
ylabel('Time(ms)');
legend('Miliseconds',1);
#5) Time-Basic Op
subplot(1,2,1);
plot(n,transpose(merge),'r')
title('Mergesort - Empiric Basic Op Data');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Basic Op',1);
subplot(1,2,2);
plot(n,transpose(mergeTime),'r')
title('Mergesort - Empiric Time Data');
xlabel('Input Size');
ylabel('Time(ms)');
legend('Miliseconds',1);

#Quick
#1)Theoretical Time Complexities
subplot(1,2,1);
hold on
plot(n,(n+1).*(n+2)./ 2,'g')
plot(n,1.39.*n.*log2(n),'r')
plot(n,n.* log2(n),'b')
title('Quick Sort - Complexities - C(n)');
xlabel('n Values');
ylabel('Complexity Values');
legend('Worst','Average','Best',1);
hold off
subplot(1,2,2);
hold on
plot(n,n.^2,'g')
plot(n,n.*log(n),'r')
plot(n,n.*log(n),'b')
title('Quick Sort - Time Complexities - T(n)');
xlabel('n values');
ylabel('Time Complexity Values');
legend('Worst','Average','Best',1);
hold off
#2)Empiric Basic Ops
plot(n,transpose(quick),'r')
title('Quick Sort - Empiric Data');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Basic Op',1);
#3)Empiric-Theoretical Basic Ops
subplot(1,2,1);
hold on
plot(n,(n+1).*(n+2)./ 2,'g')
plot(n,1.39.*n.*log2(n),'k*')
plot(n,n.* log2(n),'b')
plot(n,transpose(quick),'r')
title('Quick Sort - Empiric-Theoretical Data Comparison');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Worst','Average','Best','Observed Ops',1);
hold off
subplot(1,2,2);
hold on
plot(n,1.39.*n.*log2(n),'k*')
plot(n,n.* log2(n),'b')
plot(n,transpose(quick),'r')
title('Quick Sort - Empiric-Theoretical Data Comparison');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Average','Best','Observed Ops',1);
hold off
#4)Time
plot(n,transpose(quickTime),'r')
title('Quick Sort - Empiric Time Data');
xlabel('Input Size');
ylabel('Time(ms)');
legend('Miliseconds',1);
#5) Time-Basic Op
subplot(1,2,1);
plot(n,transpose(quick),'r')
title('Quick Sort - Empiric Basic Op Data');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Basic Op',1);
subplot(1,2,2);
plot(n,transpose(quickTime),'r')
title('Quick Sort - Empiric Time Data');
xlabel('Input Size');
ylabel('Time(ms)');
legend('Miliseconds',1);

#Heap
#1)Theoretical Time Complexities
subplot(1,2,1);
hold on
plot(n,2 .*(n-log2(n+1)) + 2 .* n.*log2(n),'g')
title('Heap Sort - Complexities - C(n)');
xlabel('n Values');
ylabel('Complexity Values');
legend('Worst',1);
hold off
subplot(1,2,2);
hold on
plot(n,n.*log(n),'g')
plot(n,n.*log(n),'r')
plot(n,n.*log(n),'b')
title('Heap Sort - Time Complexities - T(n)');
xlabel('n values');
ylabel('Time Complexity Values');
legend('Worst','Average','Best',1);
hold off
#2)Empiric Basic Ops
plot(n,transpose(heap),'r')
title('Heap Sort - Empiric Data');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Basic Op',1);
#3)Empiric-Theoretical Basic Ops
hold on
plot(n,2 .*(n-log2(n+1)) + 2 .* n.*log2(n),'g')
plot(n,transpose(heap),'r')
title('Heap Sort - Empiric-Theoretical Data Comparison');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Worst','Observed Ops',1);
hold off
#4)Time
plot(n,transpose(heapTime),'r')
title('Heap Sort - Empiric Time Data');
xlabel('Input Size');
ylabel('Time(ms)');
legend('Miliseconds',1);
#5) Time-Basic Op
subplot(1,2,1);
plot(n,transpose(heap),'r')
title('Heap Sort - Empiric Basic Op Data');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Basic Op',1);
subplot(1,2,2);
plot(n,transpose(heapTime),'r')
title('Heap Sort - Empiric Time Data');
xlabel('Input Size');
ylabel('Time(ms)');
legend('Miliseconds',1);

#Counting
#1)Theoretical Time Complexities
subplot(1,2,1);
hold on
plot(n,2.*n + 1001,'g')
plot(n,2.*n + 1001,'r')
plot(n,2.*n + 1001,'b')
title('Counting Sort - Complexities - C(n)');
xlabel('n Values');
ylabel('Complexity Values');
legend('Worst','Average','Best',1);
hold off
subplot(1,2,2);
hold on
plot(n,n + 1001,'g')
plot(n,n + 1001,'r')
plot(n,n + 1001,'b')
title('Counting Sort - Time Complexities - T(n)');
xlabel('n values');
ylabel('Time Complexity Values');
legend('Worst','Average','Best',1);
hold off
#2)Empiric Basic Ops
plot(n,transpose(counting),'r')
title('Counting Sort - Empiric Data');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Basic Op',1);
#3)Empiric-Theoretical Basic Ops
hold on
plot(n,2.*n + 1001,'g')
plot(n,2.*n + 1001,'k*')
plot(n,2.*n + 1001,'b')
plot(n,transpose(counting),'r')
title('Counting Sort - Empiric-Theoretical Data Comparison');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Worst','Average','Best','Observed Ops',1);
hold off
#4)Time
plot(n,transpose(countingTime),'r')
title('Counting Sort - Empiric Time Data');
xlabel('Input Size');
ylabel('Time(ms)');
legend('Miliseconds',1);
#5) Time-Basic Op
subplot(1,2,1);
plot(n,transpose(counting),'r')
title('Counting Sort - Empiric Basic Op Data');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Basic Op',1);
subplot(1,2,2);
plot(n,transpose(countingTime),'r')
title('Counting Sort - Empiric Time Data');
xlabel('Input Size');
ylabel('Time(ms)');
legend('Miliseconds',1);

#ALL EMPIRICS
subplot(1,2,1);
hold on
plot(n,transpose(insertion),'b')
plot(n,transpose(counting),'r')
plot(n,transpose(merge),'g')
plot(n,transpose(quick),'k')
plot(n,transpose(heap),'y')
title('All Sorts - Empiric Data');
xlabel('Input Size');
ylabel('Basic Op Count');
legend('Insertion','Others',1);
hold off
subplot(1,2,2);
hold on
plot(n,transpose(quick),'k')
plot(n,transpose(heap),'y')
plot(n,transpose(counting),'r')
plot(n,transpose(merge),'g')
title('All Sorts - Empiric Data');
xlabel('Input Size');
ylabel('Time(ms)');
legend('Quick','Heap','Counting','Merge',1);
hold off
#ALL TIMES
subplot(1,2,1);
hold on
plot(n,transpose(insertionTime),'b')
plot(n,transpose(countingTime),'r')
plot(n,transpose(mergeTime),'g')
plot(n,transpose(quickTime),'k')
plot(n,transpose(heapTime),'y')
title('All Sorts - Empiric Time Data');
xlabel('Input Size');
ylabel('Time(ms)');
legend('Insertion','Others',1);
hold off
subplot(1,2,2);
hold on
plot(n,transpose(countingTime),'r')
plot(n,transpose(mergeTime),'g')
plot(n,transpose(quickTime),'k')
plot(n,transpose(heapTime),'y')
title('All Sorts - Empiric Time Data');
xlabel('Input Size');
ylabel('Time(ms)');
legend('Quick','Heap','Counting','Merge',1);
hold off
#ALL T(n)
subplot(1,2,1);
hold on
plot(n,n.^2,'g')#insertion
plot(n,n.^2,'b')#quick
plot(n,n.*log(n),'k')#heap
plot(n,n + 1001,'y')#counting
plot(n,n.*log(n),'r')#merge
title('All Sorts - Time Complexities - T(n)');
xlabel('Input Size');
ylabel('Time Complexity Values');
legend('Insertion','Quick','Heap','Counting','Merge',1);
hold off
subplot(1,2,2);
hold on
plot(n,n.*log(n),'k')#heap
plot(n,n + 1001,'y')#counting
plot(n,n.*log(n),'r')#merge
title('All Sorts - Time Complexities - T(n)');
xlabel('Input Size');
ylabel('Time Complexity Values');
legend('Heap','Counting','Merge',1);
hold off