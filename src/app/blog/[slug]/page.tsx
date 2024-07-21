import Post from '@/components/post'
import React from 'react'

export default function BlogPost(props: { slug: string }) {

  return (
    <main className="flex min-h-screen flex-col items-center mx-auto text-stone-200">
      <Post />
    </main>
  )
}