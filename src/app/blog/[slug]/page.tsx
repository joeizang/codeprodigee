import Post from '@/components/post'
import { PostTags } from '@/index'
import React from 'react'


export interface PostProps {
  postImage?: string
  postBody?: string
  postAuthor?: string
  tags?: PostTags[]
}

export interface BlogPostProps {
  slug: string
}

export default function BlogPost (props: BlogPostProps) {
  console.log('what is in here?', props)
  return (
    <main className="flex min-h-screen flex-col items-center mx-auto text-stone-200">
      <Post />
    </main>
  )
}