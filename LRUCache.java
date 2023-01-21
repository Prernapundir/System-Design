package com.company.DoublyLinkedList;

import com.company.LinkedList.LinkedList;

import java.util.HashMap;
import java.util.Map;

public class DoublyLinkedList {
    class Node{
        int key;
        int value;
        Node next;
        Node previous;

        Node(int key,int value ,Node next,Node previous) {
            this.key=key;
            this.next = next;
            this.previous = previous;
            this.value = value;
        }
    }

    private Node head=new Node(0,0,null,null);
    private Node tail=new Node(0,0,null,null);
    private Map<Integer,Node> map=new HashMap<>();
    private int capacity=4;

    DoublyLinkedList(int capacity){
        this.capacity=capacity;
        head.next=tail;
        tail.previous=head;
    }

    // add the node after the head
    void addNode(Node node){
        map.put(node.key,node);
        node.next=head.next;
        node.previous=head;
        head.next.previous=node;
        head.next=node;
    }

    // remove node
    void removeNode(Node node){
        map.remove(node.key);
        node.previous.next=node.next;
        node.next.previous=node.previous;
    }

    void put(int key,int value){
        if(map.containsKey(key)){
            Node node=map.get(key);
            removeNode(node);
        }
        if(map.size()==capacity){
            removeNode(tail.previous);
        }
        Node node=new Node(key,value,null,null);
        addNode(node);
    }

    int get(int key){
        if(map.containsKey(key)){
            Node node=map.get(key);
            removeNode(node);
            addNode(node);
            return node.value;
        }else {
            return -1;
        }
    }

    void display(){
        head=head.next;
        while(head!=tail){
            System.out.println("{"+head.key + "," + head.value+"}");
            head=head.next;
        }
    }
}

class Main{
    public static void main(String[] args){
        DoublyLinkedList d=new DoublyLinkedList(3);
        d.put(1,2);
        d.put(3,4);
        d.put(5,6);
        d.put(6,7);
        d.get(1);
        d.get(5);
        d.display();
    }
}

