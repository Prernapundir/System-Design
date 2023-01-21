package com.company;

import java.util.*;


class MyHashMap<T,U>{

    class Node{
        T key;
        U value;

        Node(T key , U value){
            this.key=key;
            this.value=value;
        }

        @Override
        public String toString() {
            return "Node{" +
                    "key=" + key +
                    ", value=" + value +
                    '}';
        }
    }

    public int size=16;
//    public LinkedList<Node>[] list=new LinkedList[16];
     public List<Node>[] list=new LinkedList[16];
    MyHashMap(){
        for(int i=0;i<list.length;i++){
            list[i]=new LinkedList<>();
        }
    }

    // GetNodeFrom List
    Node getNode(List<Node> l,T key){
        int size=l.size();
        int i=0;

        while(i!=size){
            Node node=l.get(i);
            if(node.key.equals(key)) return node;
        }
        return null;
    }

    // Put
    public void put(T key , U value){
        int listIndex=key.hashCode()%(size-1);
        List<Node> l=list[listIndex];
        Node node = getNode(l,key);

        if(node==null){
            Node newNode=new Node(key,value);
            list[listIndex].add(newNode);
        }else {
            node.value = value;
        }
    }

    // Get
    public U get(T key){
        int listIndex=(key.hashCode())%(size-1);
        List<Node> l=list[listIndex];
        Node node = getNode(l,key);
        if(node==null) return null;
        return node.value;
    }

   public Boolean ContainsKey(T key){
       int listIndex=(key.hashCode())%(size-1);
       List<Node> l=list[listIndex];
       Node node = getNode(l,key);

       if(node==null){
           return false;
       }
       return true;
   }

   public void remove(T key){
       int listIndex=(key.hashCode())%(size-1);
       List<Node> l=list[listIndex];
       Node node = getNode(l,key);

       if(node==null) return;
       else {
           l.remove(node);
       }
   }

   public void display(){
        for(List<Node> l: list){
            System.out.println(l);
        }
   }
}

class Main{
    public static void main(String[] args){
        MyHashMap<Integer,String> m=new MyHashMap<>();
        m.put(1,"Hello");
        m.put(5,"World");

        m.put(4,"Pundir");
        m.put(5,"temp");

        m.display();

    }
}
