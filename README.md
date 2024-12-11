# Kruskal-s-algorithm
# Part (a): Write all required algorithms for MST using Kruskal's Algorithm

## 1)Key Components of Kruskal’s Algorithm:
        → Graph Representation: Define the graph using an edge list where each edge includes (source, destination, weight).
        → Sort Edges: Sort all edges in non-decreasing order of weight.
        → Union-Find Data Structure: Use a union-find (disjoint-set) data structure to manage connected components.
        → Iterative Edge Selection: Add edges to the MST while ensuring no cycles are formed.

## 2)Algorithms Needed:
  ### ► Union-Find Operations:
      → Find: Determine the root of a set.
      → Union: Merge two sets.
      → Path compression and union by rank for optimization.
  ### ► Kruskal’s Algorithm:
      → Initialize the MST as an empty set.
      → Sort the edges by weight.
      → Process edges in ascending weight order, using the union-find to check for cycles.
      → Add valid edges to the MST until it contains V-1 edges (where V is the number of vertices).
           
