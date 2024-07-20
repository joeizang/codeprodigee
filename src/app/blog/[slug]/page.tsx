import Post from '@/components/post'
import { BlogPostProps, PostTags } from '@/index'
import React from 'react'

export default function BlogPost(props: BlogPostProps) {

  return (
    <main className="flex min-h-screen flex-col items-center mx-auto text-stone-200">
      <Post />
    </main>
  )
}