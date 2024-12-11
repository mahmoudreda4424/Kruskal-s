# Kruskal-s-algorithm
# Part (a): Write all required algorithms for MST using Kruskal's Algorithm

      1)Key Components of Kruskal’s Algorithm:
          → Graph Representation: Define the graph using an edge list where each edge includes (source, destination, weight).
          → Sort Edges: Sort all edges in non-decreasing order of weight.
          → Union-Find Data Structure: Use a union-find (disjoint-set) data structure to manage connected components.
          → Iterative Edge Selection: Add edges to the MST while ensuring no cycles are formed.

      2)Algorithms Needed:
          ►Edge Class:
             Represents an edge with:
              → Source: Starting vertex.
              → Destination: Ending vertex.
              → Weight: The cost of the edge.
              → Implements IComparable to allow sorting edges by weight.
        
          ► Union-Find Operations:
              → Find: Determine the root of a set.
              → Union: Merge two sets.
              → Path compression and union by rank for optimization.
          ► Kruskal’s Algorithm:
              → Initialize the MST as an empty set.
              → Sort the edges by weight.
              → Process edges in ascending weight order, using the union-find to check for cycles.
              → Add valid edges to the MST until it contains V-1 edges (where V is the number of vertices).
      
## 3)Algorithm:
        KRUSKAL(G):
        A = ∅
        For each vertex v ∈ G.V:
            MAKE-SET(v)
        sort the edges of G.E into increasing order by weight
        For each edge (u, v) ∈ G.E ordered by increasing order by weight(u, v):
            if FIND-SET(u) ≠ FIND-SET(v):       
            A = A ∪ {(u, v)}
            UNION(u, v)
        return A

# Part(b). Analyze in detail your written algorithms in Part (a)
          ►Time complexity analysis
             1)Time Complexity:
                T(n) = O(1) + O(V) + O(E log E) + O(V log V)
                T(n) =O(E log E) + O(V log V) [As |E| ≥ |V| — 1]
                T(n) = E log E + E log E
                T(n) = E log E
                Hence, time complexity of Kruskal’s algorithm is O(E log E), or we can also say O(E log V) because; 
                E <= V * V
                So, by taking log on both sides, log(E)<=2 log(V)
                Hence, time complexity of Kruskal is O(E log E) or O(E log V).
                
             2)Space Complexity:
                Storing edges: O(E).
                Union-Find arrays:O(V).
                Total:O(V+E).
        
           ►Detailed analysis of time complexity
                All the edges are maintained as min heap.
                The next edge can be obtained in O(log E) runtime, where E is number of edges.
                Reconstruction of heap takes O(E) time.
                Hence, this algorithm takes O(E log E) time.
                The value of E can be at most O(V²).
                So, O(log V) and O(log E) are same.
                Therefore, time complexity of Kruskal’s Algorithm is O(E log E) or O(E log V)
                
           ►Worst case time complexity of Kruskal’s Algorithm
                Worst case will happen when;
                the graph contains maximum number of edges possible which equals to n(n-1)/2,
                all the edges are not sorted, and
                our MST includes the edge with maximum weight.
                In this situation, we need to check all the edges and make sure all of the edges with least weight are in the minimum spanning tree. Then,
                
                Sorting all the edges by using merge sort would take O(E log E) time. We sort it by merge sort because that is the most optimal choice.
                
                The MAKE-SET function would take a runtime of O(V), as it creates a subset for all of the vertices.
                
                Union and find function makes sure that the final tree structure stays at minimum height, resulting in an overall execution time of O(E log E) for both the functions.
                
                Therefore, in the worst case, the total complexity comes out to be O(E log E), as shown below:
                
                T(n) = E log E + V + E log E
                T(n) = E log E
        
           ►Best case time complexity of Kruskal’s Algorithm
                Best case will be when;
                
                the graph has lowest number of possible edges connecting all the nodes or vertices
                all the edges have already been sorted.
                Then,
                
                All the edges are already sorted, therefore it’ll have O(1) runtime.
                
                The MAKE-SET will have the same runtime as the worst case, which is O(V).
                
                Theoretically, the union and find functions would have runtime of Log(E) for each edge. When we do this for all valid edges and vertices, the total time complexity will be O(E log E).
                
                As E = V-1, the total time complexity comes out to be O(E log E).
        
           ►Average case time complexity of Kruskal’s Algorithm
                In average case;
                
                The sorting will take place. We will use merge sort for this as used in worst case situation. Therefore, it will take O(E log E) runtime.
                
                Again, the MAKE-SET function would take a runtime of O(V), as it creates a subset of all of the vertices.
                
                In union and find function, we consider two subtrees or two vertices at a time. So, the execution time here will be same as worst case, i.e., O(E log E).
                
                Hence, the time complexity in average case equals to O(E log E).
                
                Space complexity of Kruskal’s Algorithm
                A space requirement of O(V) to keep track of all vertices in the beginning and the respective subsets.
                
                To keep track of all the vertices and the subsets, O(V) space is required.
                
                A space requirement of O(E) to keep track of all the valid sorted edges to be included in the final MST.
                
                Therefore, the total space complexity turns out to be O(E+V).

## Summary:
        Worst case time complexity: O(E log E)
        Best case time complexity: O(E log E)
        Average case time complexity: O(E log E)
        Space complexity: O(E+V)        
                





